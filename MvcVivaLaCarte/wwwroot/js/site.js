// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const defaultUser = {
    FullName: "Joe Biden",
    Username: "nomalarky",
    DOB: "1942-11-20",
    Email: "presjoe12@whitehouse.gov",
    Password: "$p@ma&3665",
    Gender: "Male",
    Address: {
        street: "1600 Pennsylvania Avenue NW",
        postcode: "20500",
        city: "Washington D.C."
    },
    Phone: "2024561111",
    Country: "Poland"
}


// Register Page Development Utility
function FillRegistrationForm() {
    document.getElementById("user_fullName").value = defaultUser.FullName;
    document.getElementById("user_username").value = defaultUser.Username;
    document.getElementById("user_birthday").value = defaultUser.DOB;
    document.getElementById("user_email").value = defaultUser.Email;
    document.getElementById("user_password").value = defaultUser.Password;
    document.getElementById("user_password_confirmation").value = defaultUser.Password;
    document.getElementById("male").checked = true;
    document.getElementById("user_street_nr").value = defaultUser.Address.street;
    document.getElementById("user_postal_code").value = defaultUser.Address.postcode;
    document.getElementById("user_city").value = defaultUser.Address.city;
    document.getElementById("user_phone_nr").value = defaultUser.Phone;
    document.getElementById("country").value = defaultUser.Country;


}

FillRegistrationForm();