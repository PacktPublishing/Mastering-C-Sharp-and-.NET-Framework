
/*
 * GET home page.
 */
exports.index = function (req, res) {
    res.render('index', 
        {
        title: 'Mastering C# and .NET Programming', 
        subtitle: 'Published by PACKT Publishing'
    }
    );
};