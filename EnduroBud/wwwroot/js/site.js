// Write your Javascript code.
$(#"delete-action").on("click", function () {
    $.ajax({
        // edit to add steve's suggestion.
        //url: "/ControllerName/ActionName",
        url: '<%= Url.Action("Delete", "Activity") %>',
        success: function (data) {
            // your data could be a View or Json or what ever you returned in your action method 
            // parse your data here
            alert(data);
        }
    });
       
    })