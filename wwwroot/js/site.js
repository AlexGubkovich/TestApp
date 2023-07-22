function getRequest(uri, handleData) {
    fetch(uri)
        .then(respose => respose.json())
        .then(data => handleData(data))
        .catch(error => console.error(error));
}

function formatDate(date) {
    return (date.getMonth() + 1) + "/" + date.getDate() + "/" + date.getFullYear();
}