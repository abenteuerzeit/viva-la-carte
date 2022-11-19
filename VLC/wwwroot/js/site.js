// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.

// ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ ~ ~ ||
//                  TODO
// ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ ~ ~ ||
// 1. Get user cookbook from server
// 2. send recipe data to controller
// ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ~ ~ ~ ~ ||


//////////////////////////////////////////////////////////////
// #region DEV TOOLS 
//////////////////////////////////////////////////////////////
function alertWhenErrorCaught(functionName, errorData) {
    console.warn(
        "An error was thrown! "
    )
    try {
        console.error(errorData);
        console.error(functionName);
        alert(
            errorData + "\n" +
            functionName
        );
    } catch (err) {
        console.error(err);
        console.error(alertWhenErrorCaught);
        alert(
            "Something went wrong!"
        );
    }
}

// TODO: Refactor = change name to postToServer(date, url)

function sendToServer(data, url) {
    try {
        //$.ajax({
        //    type: "POST",
        //    data: JSON.stringify(data),
        //    url: url,
        //    contentType: "application/json"
        //});

        let xhr = new XMLHttpRequest();
        xhr.open("POST", url, true);
        xhr.setRequestHeader("Content-Type", "application/json");
        xhr.onreadystatechange = () => {
            if (xhr.readyState === 4 && xhr.status === 200) {
                //alert(xhr.responseText);
                console.info(this.responseText);

                // Failed to match method call Microsoft.WebTools.BrowserLink.LivePreview.LivePreviewBrowserUIExtensionFactory.themeChanged
            }
        };
        var stringifiedData = JSON.stringify(data);
        xhr.send(stringifiedData);
    } catch (err) {
        alertWhenErrorCaught(sendDataToServer, err);
    }
}


// #endregion
//////////////////////////////////////////////////////////////
// # region RECIPES SEARCH RESULTS PAGE
//////////////////////////////////////////////////////////////

function toggleAddToCookbookButton(id) {
    try {

        let btn = document.getElementById(id);
        var added = "Recipe Saved!";
        var notAdded = "Save to Cookbook";

        if (btn.innerHTML === added) {
            throw Error("Remove recipe funciton not implemened!\n");
        }

        btn.innerHTML = btn.innerText === notAdded ? btn.innerText = added : btn.innerText = notAdded;

    } catch (err) {
        alertWhenErrorCaught(toggleAddToCookbookButton, err);
    }

}

function getCookbookById() {
    try {
        throw Error("Not implemented");

    } catch (err) {
        alertWhenErrorCaught(GetCookbook, err);
    }
}



function saveToCookbook(recipeJsonObject, url) {
    try {
        sendToServer(recipeJsonObject, url)
    }
    catch (err) {
        alertWhenErrorCaught(saveToCookbook, err);
    }
}


function deleteFromCookbook() {
    try {
        throw Error("Not implemented");

    } catch (err) {
        alertWhenErrorCaught(deleteFromCookbook, err);
    }
}


function updateIsFavoriteProperty() {
    try {
        throw Error("Not implemented");

    } catch (err) {
        alertWhenErrorCaught(updateIsFavoriteProperty, err);
    }
}


function calculate() {
    try {
        var inputs = document.getElementsByTagName('input');
        inputs[14].value = Math.ceil(((10 * inputs[9].value) + (6.25 * inputs[8].value) - (5 * inputs[10].value) + 5));
    } catch (err) {
        alertWhenErrorCaught(calculate, err);
    }
    

}