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


function sendToServer(data, url) {
    try {
        let xhr = new XMLHttpRequest();
        xhr.open("POST", url, true);
        xhr.setRequestHeader("Content-Type", "application/json");
        xhr.onreadystatechange = () => {
            if (xhr.readyState === 4 && xhr.status === 200) {
                console.log(this.responseText);

            }
        };
        var strigifiedData = JSON.stringify(data);
        console.log(strigifiedData);
        xhr.send(strigifiedData);
    } catch (err) {
        alertWhenErrorCaught(sendDataToServer, err);
    }
}


// #endregion
//////////////////////////////////////////////////////////////
// # region RECIPES SEARCH RESULTS PAGE
//////////////////////////////////////////////////////////////

function ToggleFavorite(id) {
    try {
        let btn = document.getElementById(id);
        btn.innerHTML = btn.innerText === "Save to Cookbook" ? btn.innerText = "&#128505; Recipe Saved!" : btn.innerText = "Save to Cookbook";
    } catch (err) {
        alertWhenErrorCaught(ToogleFavorite, err);
    }

}


function SaveToCookbook(recipeJsonObject, url) {
    try {
        console.log(recipeJsonObject);
        sendToServer(recipeJsonObject, url)
    }
    catch (err) {
        alertWhenErrorCaught(SaveToCookbook, err);
    }
}


function DeleteFromCookbook() {
    try {
        throw Error("Not implemented");

    } catch (err) {
        alertWhenErrorCaught(DeleteFromCookbook, err);
    }
}


function UpdateIsFavoriteProperty() {
    try {
        throw Error("Not implemented");

    } catch (err) {
        alertWhenErrorCaught(UpdateIsFavoriteProperty, err);
    }
}

