function getRequest(uri, handleData) {
    fetch(uri)
        .then(respose => respose.json())
        .then(data => handleData(data))
        .catch(error => console.error(error));
}