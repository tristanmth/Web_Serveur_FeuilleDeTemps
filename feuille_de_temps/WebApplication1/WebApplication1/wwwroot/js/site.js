// Exemple de script pour validation
document.addEventListener("DOMContentLoaded", () => {
    const form = document.querySelector("form");
    if (form) {
        form.addEventListener("submit", (event) => {
            const inputs = form.querySelectorAll("input[type='number']");
            let valid = true;

            inputs.forEach((input) => {
                if (input.value < 0) {
                    alert("Le temps saisi ne peut pas être négatif.");
                    input.focus();
                    valid = false;
                    event.preventDefault();
                }
            });

            if (!valid) {
                event.preventDefault();
            }
        });
    }
});
