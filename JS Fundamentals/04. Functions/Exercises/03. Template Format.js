function convertToXML(input) {
    let result = '<?xml version="1.0" encoding="UTF-8"?>\n<quiz>\n';
    for (let i = 0; i < input.length; i += 2) {
        result += `  <question>\n    ${input[i]}\n  </question>\n` +
            `  <answer>\n    ${input[i + 1]}\n  </answer>\n`
    }

    result += '</quiz>';

    return result;
}