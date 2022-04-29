function downloadFile(file, Content) {
    var link = document.createElement('a');
    link.download = file;
    link.href = "data:application/json;charset=utf-8," + encodeURIComponent(Content)
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}