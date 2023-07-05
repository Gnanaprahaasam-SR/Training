var http = require("http");

http.createServer(function(req,res) {
    res.writeHead(200,{'content-Tyep':'text/plain'});
    res.end('<h1>hello World</h1>');
    
}).listen(8080);

