/// <reference path="../App.js" />

(function () {
    "use strict";

    // The initialize function must be run each time a new page is loaded
    Office.initialize = function (reason) {
        $(document).ready(function () {
            app.initialize();
            $('#get-data-from-selection').click(getDataFromSelection);
            $('#insert-data-from-Task-Pane').click(insertDataFromTaskPane);
        });
    };

    // Reads data from current document selection and displays a notification
    function getDataFromSelection() {
        Office.context.document.getSelectedDataAsync(Office.CoercionType.Text,
            function (result) {
                if (result.status === Office.AsyncResultStatus.Succeeded) {
                    app.showNotification('The selected text is:', '"' + result.value + '"');
                } else {
                    app.showNotification('Error:', result.error.message);
                }
            }
        );
    }
    function insertDataFromTaskPane() {
        Office.context.document.setSelectedDataAsync(
                'Text inserted from the Task Pane' +
                '\nCallaback function notifies status',
                function (result) {
                app.showNotification('Feedback:', result.status);
            });
    }

})();