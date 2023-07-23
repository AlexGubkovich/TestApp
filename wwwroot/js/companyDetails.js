function displayCompanyDetails(company) {
    $('#companyNameHeader').val(company.name);
    displayCompanyInfo(company);
    displayHistory(company.history);
    displayNotes(company.notes);
    displayEmployees(company.employees);
}

function displayEmployee(employee) {
    $('#employeeFirstName').val(employee.firstName);
    $('#employeeLastName').val(employee.lastName);
    $('#employeeTitle').val(employee.title);
    $('#employeeBirthDate').val(new Date(employee.birthDate).toISOString().substring(0, 10));
    $('#employeePosition').val(employee.position);
}

function displayCompanyInfo(company) {
    $('#companyId').val(company.id);
    $('#companyName').val(company.name);
    $('#companyAddress').val(company.address);
    $('#companyCity').val(company.city);
    $('#companyState').val(company.state);
}

function displayHistory(history) {
    $('#history > tbody tr').remove()
    $.each(history, function (i, order) {
        $('#history > tbody')
            .append(`
                <tr>
                    <td>${formatDate(new Date(order.orderDate))}</td>
                    <td>${order.storeCity}</td>
                </tr>
            `)
    });
}

function displayNotes(notes) {
    $('#notes > tbody tr').remove()
    $.each(notes, function (i, note) {
        $('#notes > tbody')
            .append(`
                <tr>
                    <td>${note.invoiceNumber}</td>
                    <td>${note.employeeFullName}</td>
                </tr>
            `)
    });
}

function displayEmployees(employees) {
    $('#employees > tbody tr').remove()
    $.each(employees, function (i, employee) {
        $('#employees > tbody')
            .append(`
                <tr>
                    <td>${employee.firstName}</td>
                    <td>${employee.lastName}</td>
                </tr>
            `);
        $('#employees tr:last').click(function () {
            $(this).addClass('highlight').siblings().removeClass('highlight');
            displayEmployee(employee)
        })
    });
}