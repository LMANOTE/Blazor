// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

window.exampleJsFunctions = {
    showPrompt: function (message) {
        return prompt(message, 'Type anything here');
    }
};
