package main

import (
    "strings"
//         "bufio"
        "fmt"
        "io/ioutil"
//         "os"
)

func main() {
 m  := map[string]string {
"html": "https://docs.fileformat.com/web/html/",
"xhtml": "https://docs.fileformat.com/web/xhtml/",
"mhtml": "https://docs.fileformat.com/web/mhtml/",
"epub": "https://docs.fileformat.com/ebook/epub/",
"svg": "https://docs.fileformat.com/page-description-language/svg/",
"md": "https://docs.fileformat.com/word-processing/md/",
"pdf": "https://docs.fileformat.com/pdf/",
"xps": "https://docs.fileformat.com/page-description-language/xps/",
"tiff": "https://docs.fileformat.com/image/tiff/",
"jpeg": "https://docs.fileformat.com/image/jpeg/",
"png": "https://docs.fileformat.com/image/png/",
"bmp": "https://docs.fileformat.com/image/bmp/",
}


    for j,i := range m {

        href := fmt.Sprintf("<a href=\"%s\">%s</a>", i, strings.ToUpper(j))
        fileName := fmt.Sprintf("%s.html",  strings.ToUpper(j))
         fmt.Printf("File name == "+fileName+"\n");
        err := ioutil.WriteFile(fileName,  []byte(href), 0644)
        check(err)
//         f, err := os.Create(fileName)
//         check(err)
//         defer f.Close()
//         f.WriteString(href)

    }
}


func check(e error) {
    if e != nil {
        panic(e)
    }
}