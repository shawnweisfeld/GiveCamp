function updateCharactersLeftTextBlock(textblock, messageDiv) {
    var usedCharacters = $(textblock).val().length;
    var totalCharacters = $(textblock).attr('data-limit');
    var unusedCharacters = totalCharacters - usedCharacters;

    $(messageDiv).html(unusedCharacters + " characters left");
}