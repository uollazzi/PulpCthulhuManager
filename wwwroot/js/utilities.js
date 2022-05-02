function makeSelectable() {
    document.querySelectorAll(".select-all").forEach(element => {
        element.addEventListener("focus", () => {
            element.select();
        });
    });
}
