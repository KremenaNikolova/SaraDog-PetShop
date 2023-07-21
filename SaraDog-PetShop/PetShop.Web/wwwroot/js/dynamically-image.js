document.getElementById("image-input").addEventListener("change", function () {
    var file = this.files[0];
    if (file) {
        var reader = new FileReader();
        reader.onload = function (e) {
            document.getElementById("image-preview").src = e.target.result;
            document.getElementById("image-preview").style.display = "block";
        };
        reader.readAsDataURL(file);
    } else {
        // If no file is selected, you can handle it here, e.g., display a placeholder image or show an error message.
        document.getElementById("image-preview").src = "";
        document.getElementById("image-preview").style.display = "none";
    }
});