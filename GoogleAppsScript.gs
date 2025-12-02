/**
 * Google Apps Script for Contact Form Submission
 * 
 * INSTRUCTIONS:
 * 1. Open Google Sheets and create a new spreadsheet (or use an existing one)
 * 2. Go to Extensions > Apps Script
 * 3. Delete the default code and paste this entire script
 * 4. Replace 'Sheet1' with your actual sheet name if different
 * 5. Click the Save icon (or press Ctrl+S)
 * 6. Click Deploy > New deployment
 * 7. Click the gear icon next to "Select type" and choose "Web app"
 * 8. Set the following:
 *    - Description: Contact Form Handler
 *    - Execute as: Me
 *    - Who has access: Anyone
 * 9. Click Deploy
 * 10. Copy the Web App URL and paste it into your appsettings.json file
 *     under "GoogleAppsScript:WebAppUrl"
 * 11. Click Authorize access and follow the prompts
 * 12. You may need to click "Advanced" > "Go to [Project Name] (unsafe)" if prompted
 */

// Configuration: 
// Spreadsheet ID: 1WKQgwE8xoJ6yiuaK-TEH7bFfFBGOKSYlLmgOAKMS-Uo
// Sheet name: Sheet1 (change if your sheet tab has a different name)
const SPREADSHEET_ID = '1WKQgwE8xoJ6yiuaK-TEH7bFfFBGOKSYlLmgOAKMS-Uo';
const SHEET_NAME = 'Sheet1';

/**
 * Handles POST requests from the contact form
 * @param {Object} e - The event object containing form data
 * @return {Object} Response object
 */
function doPost(e) {
  try {
    // Parse the JSON data from the request
    const data = JSON.parse(e.postData.contents);
    
    // Get the spreadsheet by ID (more reliable than getActiveSpreadsheet for Web Apps)
    const spreadsheet = SpreadsheetApp.openById(SPREADSHEET_ID);
    let sheet = spreadsheet.getSheetByName(SHEET_NAME);
    
    // If sheet doesn't exist, create it
    if (!sheet) {
      sheet = spreadsheet.insertSheet(SHEET_NAME);
      // Add headers if this is a new sheet
      sheet.getRange(1, 1, 1, 6).setValues([['Timestamp', 'Name', 'Email', 'Phone', 'Subject', 'Message']]);
      sheet.getRange(1, 1, 1, 6).setFontWeight('bold');
      sheet.getRange(1, 1, 1, 6).setBackground('#4285f4');
      sheet.getRange(1, 1, 1, 6).setFontColor('#ffffff');
    }
    
    // Use the sheet we found or created
    const targetSheet = sheet;
    
    // Check if headers exist, if not add them
    if (targetSheet.getLastRow() === 0) {
      targetSheet.getRange(1, 1, 1, 6).setValues([['Timestamp', 'Name', 'Email', 'Phone', 'Subject', 'Message']]);
      targetSheet.getRange(1, 1, 1, 6).setFontWeight('bold');
      targetSheet.getRange(1, 1, 1, 6).setBackground('#4285f4');
      targetSheet.getRange(1, 1, 1, 6).setFontColor('#ffffff');
    }
    
    // Prepare the row data
    const rowData = [
      data.timestamp || new Date().toLocaleString(),
      data.name || '',
      data.email || '',
      data.phone || '',
      data.subject || '',
      data.message || ''
    ];
    
    // Append the new row
    targetSheet.appendRow(rowData);
    
    // Optional: Format the new row
    const lastRow = targetSheet.getLastRow();
    targetSheet.getRange(lastRow, 1, 1, 6).setBorder(true, true, true, true, true, true);
    
    // Return success response
    return ContentService.createTextOutput(JSON.stringify({
      success: true,
      message: 'Form submitted successfully'
    })).setMimeType(ContentService.MimeType.JSON);
    
  } catch (error) {
    // Log error for debugging (check in Apps Script execution log)
    console.error('Error in doPost:', error.toString());
    console.error('Stack trace:', error.stack);
    
    // Return error response
    return ContentService.createTextOutput(JSON.stringify({
      success: false,
      message: 'Error processing form: ' + error.toString(),
      error: error.toString()
    })).setMimeType(ContentService.MimeType.JSON);
  }
}

/**
 * Handles GET requests (for testing)
 * @return {Object} Response object
 */
function doGet(e) {
  return ContentService.createTextOutput(JSON.stringify({
    status: 'OK',
    message: 'Contact Form Handler is running',
    timestamp: new Date().toISOString()
  })).setMimeType(ContentService.MimeType.JSON);
}

