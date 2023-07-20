document.getElementById("image-input").addEventListener("change", function () {
    var reader = new FileReader();
    reader.onload = function (e) {
        document.getElementById("image-preview").src = e.target.result;
        document.getElementById("image-preview").style.display = "block";
    };
    reader.readAsDataURL(this.files[0]);
});
