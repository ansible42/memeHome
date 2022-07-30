# memeHome

Learning playground for me to get to know the github actions and how to use static page generators. Also just funny and a good link to share with other super-nerds. 


## Design 

Content branch contains a folder ```/content``` when when uploaded adds the new pictures (*.png, *.jpg and *.gif) to the markdown page.  Once the markdown is updated it is pushed to the ```gh-pages``` branch and processed into a [jekyell workflow](https://jekyllrb.com/docs/continuous-integration/github-actions/). 

## How To use

* Open PR to add new memes to the ```/content``` folder. 
* Wait for CI to complete (less than 60s normally)
* Go to https://ansible42.github.io/memeHome and see the updated list.   