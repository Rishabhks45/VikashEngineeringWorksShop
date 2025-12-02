# Google Sheets Integration Setup Guide

This guide will help you set up the contact form to store submissions in Google Sheets using Google Apps Script.

## Step 1: Create a Google Sheet

1. Go to [Google Sheets](https://sheets.google.com)
2. Create a new spreadsheet (or use an existing one)
3. Name it something like "Contact Form Submissions"

## Step 2: Set Up Google Apps Script

1. In your Google Sheet, go to **Extensions** > **Apps Script**
2. Delete any default code in the editor
3. Copy the entire contents of `GoogleAppsScript.gs` from this project
4. Paste it into the Apps Script editor
5. **Important**: If your sheet name is not "Sheet1", change the `SHEET_NAME` constant in the script (line 18)
6. Click the **Save** icon (or press Ctrl+S / Cmd+S)
7. Give your project a name (e.g., "Contact Form Handler")

## Step 3: Deploy as Web App

1. In the Apps Script editor, click **Deploy** > **New deployment**
2. Click the gear icon (⚙️) next to "Select type" and choose **Web app**
3. Configure the deployment:
   - **Description**: Contact Form Handler
   - **Execute as**: Me (your email)
   - **Who has access**: Anyone (this allows your website to submit data)
4. Click **Deploy**
5. You'll be prompted to authorize the script:
   - Click **Authorize access**
   - Sign in with your Google account
   - Click **Advanced** if you see a warning
   - Click **Go to [Project Name] (unsafe)** if prompted
   - Click **Allow** to grant permissions
6. **Copy the Web App URL** - you'll need this in the next step

## Step 4: Configure Your Application

1. Open `appsettings.json` in your project
2. Find the `GoogleAppsScript` section
3. Replace `YOUR_GOOGLE_APPS_SCRIPT_WEB_APP_URL_HERE` with the Web App URL you copied in Step 3
4. Save the file

Example:
```json
"GoogleAppsScript": {
  "WebAppUrl": "https://script.google.com/macros/s/AKfycby.../exec"
}
```

## Step 5: Test the Integration

1. Run your application
2. Navigate to the Contact page
3. Fill out and submit the contact form
4. Check your Google Sheet - you should see a new row with the submission data

## Troubleshooting

### Form submissions not appearing in Google Sheets

1. **Check the Web App URL**: Make sure it's correctly set in `appsettings.json`
2. **Check sheet name**: Ensure the `SHEET_NAME` in the script matches your actual sheet name
3. **Check permissions**: Make sure the Web App is deployed with "Anyone" access
4. **Check browser console**: Open browser developer tools (F12) and check for any error messages
5. **Test the script directly**: You can test the Web App URL directly in a browser - it should return a JSON response

### Authorization issues

- If you see authorization errors, redeploy the Web App and ensure you've granted all necessary permissions
- The script needs permission to access and edit your Google Sheet

### Data format

The form will create columns in this order:
- Timestamp
- Name
- Email
- Phone
- Subject
- Message

The first row will automatically be formatted as headers with a blue background.

## Security Note

The Web App URL is publicly accessible, but it only allows POST requests with valid JSON data. The script validates the incoming data before writing to your sheet. For additional security, you can:

1. Add a secret token in the request
2. Validate the token in the Apps Script
3. Use Google Apps Script's built-in authentication features

## Updating the Script

If you need to update the script:

1. Make your changes in the Apps Script editor
2. Click **Deploy** > **Manage deployments**
3. Click the edit icon (✏️) next to your deployment
4. Click **New version** to create a new version
5. Click **Deploy**

The Web App URL will remain the same, so no changes are needed in your application configuration.

