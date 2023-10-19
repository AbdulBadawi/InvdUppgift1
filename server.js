const http = require('http');
const fs = require('fs');
const path = require('path');

const server = http.createServer((req, res) => {
  if (req.url === '/') {
    // Läs HTML-filen
    fs.readFile(path.join(__dirname, 'Index.html'), 'utf8', (err, data) => {
      if (err) {
        res.writeHead(500);
        res.end('Server Error');
      } else {
        // Läs CSS-filen
        fs.readFile(path.join(__dirname, 'styles.css'), 'utf8', (err, css) => {
          if (err) {
            res.writeHead(500);
            res.end('Server Error');
          } else {
            // Skicka HTML-sidan med inkluderad CSS
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.end(data.replace('<link rel="stylesheet" type="text/css" href="styles.css">', `<style>${css}</style>`));
          }
        });
      }
    });
  } else {
    res.writeHead(404);
    res.end('Page Not Found');
  }
});

const port = 3000;
server.listen(port, () => {
  console.log(`Server is running on port ${port}`);
});
