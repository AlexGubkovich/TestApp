const uri = 'api/companies';

function getCompanies() {
    fetch(uri)
        .then(respose => respose.json())
        .then(data => displayCompanies(data))
        .catch(error => console.error('Unable to get items.', error));
}

function displayCompanies(companies) {
    $.each(companies, function (i, company) {
        $('#companiesTable > tbody:last-child')
            .append(`<tr><td>${company.name}</td><td>${company.city}</td><td>${company.state}</td><td>${company.phone}</td></tr>`)
    })
}

window.onload = getCompanies();