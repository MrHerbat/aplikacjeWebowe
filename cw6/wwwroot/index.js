function getCurrentDateTime() {
    const now = new Date();

    const currentDateTime = now.toLocaleString();

    document.querySelector("#dateTime").innerHTML = currentDateTime;
}
setInterval(getCurrentDateTime, 1000);