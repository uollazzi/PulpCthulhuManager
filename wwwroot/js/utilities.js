function makeSelectable() {
    document.querySelectorAll(".select-all").forEach(element => {
        element.addEventListener("focus", () => {
            element.select();
        });
    });
}

function bodyOverflow(hidden) {
    const body = document.querySelector("body");
    body.style.overflow = hidden ? "hidden" : "auto";
}
