function getArticleGenerator(articles) {
    return function() {
        if (articles.length === 0) {
            return
        }
        
        let article = $('<article>');
        article.append($(`<p>${articles.shift()}</p>`));
        $('#content').append(article);
    }
}
