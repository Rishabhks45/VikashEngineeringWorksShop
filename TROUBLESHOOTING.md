# Troubleshooting: Google Sheets Not Receiving Data

If your form shows "Message sent successfully" but the Google Sheet is blank, follow these steps:

## Step 1: Update the Google Apps Script

The script needs to know which spreadsheet to use. You need to:

1. **Get your Spreadsheet ID:**
   - Open your Google Sheet
   - Look at the URL: `https://docs.google.com/spreadsheets/d/SPREADSHEET_ID/edit`
   - Copy the `SPREADSHEET_ID` (the long string between `/d/` and `/edit`)

2. **Update the Script:**
   - Go to your Google Sheet → Extensions → Apps Script
   - Find this line: `const SPREADSHEET_ID = 'YOUR_SPREADSHEET_ID';`
   - Replace `YOUR_SPREADSHEET_ID` with your actual Spreadsheet ID
   - Example: `const SPREADSHEET_ID = '1ABC123XYZ456DEF789';`

3. **Save and Redeploy:**
   - Click Save (Ctrl+S)
   - Click Deploy → Manage deployments
   - Click the edit icon (✏️) next to your deployment
   - Click "New version"
   - Click "Deploy"
   - **Important:** The Web App URL stays the same, so no need to update appsettings.json

## Step 2: Check the Sheet Name

1. In your Google Sheet, check the name of the tab at the bottom
2. In the Apps Script, make sure `SHEET_NAME` matches exactly (case-sensitive)
3. Default is `'Sheet1'` - if your sheet tab has a different name, update it

## Step 3: Check Permissions

1. Make sure the Web App is deployed with:
   - **Execute as:** Me
   - **Who has access:** Anyone
2. If you changed permissions, you need to redeploy

## Step 4: Test the Script Directly

1. Open your Google Sheet → Extensions → Apps Script
2. Click on the function dropdown and select `doGet`
3. Click the Run button (▶️)
4. Authorize if prompted
5. You should see a success message
6. This confirms the script can access your sheet

## Step 5: Check Execution Logs

1. In Apps Script, click "Executions" (clock icon) in the left sidebar
2. You'll see all script executions
3. Click on recent executions to see if there are any errors
4. Check the logs for error messages

## Step 6: Test with Browser Console

1. Open your website
2. Press F12 to open Developer Tools
3. Go to the Console tab
4. Submit the contact form
5. Look for any error messages in the console
6. Check the Network tab to see the request/response

## Step 7: Verify the Data Format

The script expects this JSON format:
```json
{
  "timestamp": "2024-01-01 12:00:00",
  "name": "John Doe",
  "email": "john@example.com",
  "phone": "+1234567890",
  "subject": "Test",
  "message": "Test message"
}
```

## Common Issues and Solutions

### Issue: "Script function not found"
**Solution:** Make sure the function is named exactly `doPost` (case-sensitive)

### Issue: "Spreadsheet not found"
**Solution:** 
- Check that SPREADSHEET_ID is correct
- Make sure the spreadsheet is accessible (not deleted or moved to trash)
- Ensure the script has permission to access the sheet

### Issue: "Sheet not found"
**Solution:**
- Check that SHEET_NAME matches your sheet tab name exactly
- The script will create the sheet if it doesn't exist, but only if it can access the spreadsheet

### Issue: Data appears but then disappears
**Solution:** 
- Check if you have any filters or sorting applied that might hide rows
- Check if there are any other scripts or formulas that might be clearing data

### Issue: Headers appear but no data rows
**Solution:**
- Check the execution logs in Apps Script
- The script might be failing silently
- Try submitting the form again and check the logs immediately

## Quick Test

To quickly test if everything is working:

1. Update the SPREADSHEET_ID in the script
2. Save and redeploy
3. Submit a test form
4. Immediately check your Google Sheet
5. Check the Apps Script execution logs

If data still doesn't appear, check the execution logs for the exact error message.

