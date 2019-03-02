# HIMS.EF 
## Human resource management system  :books:

1) How to resolve issue with PK in views generated by EF?
- Read following links to figure it out and apply to your part of solution:
https://stackoverflow.com/questions/24792259/error-6002-the-table-view-does-not-have-a-primary-key-defined
https://www.dustinhorne.com/post/2016/12/10/views-and-incorrect-data-in-entity-framework

2) ### Good tutorial in ENGLISH to read about EF
- http://www.entityframeworktutorial.net

3) ### If you add new entity, procedure, view and etc., you need: 	<br/>
	a) run script to add it to database on your local server <br/>
	b) save script in HIMS.Database solution in an appropriate folder 
	<br/>
	c) update your HIMS.edmx model from your database 
	<br/>
	d) commit your changes

4) ### Git workflow
- name of branch: <your-name><feature>
```
git checkout dev
git pull (resolve conflicts if need)
	
git checkout -b <your-branch-name>
git status
git add . / git add "<name-of-file>"
git commit -m "<your-commit>"
git push -u origin <your-branch-name>  // -u or --set-upstream
	
git checkout dev
git pull (resolve conflicts if need)
git merge <your-branch> dev
git branch -d <your-branch>
	
git push
```
- https://rogerdudler.github.io/git-guide/ - refresh you git knowledges step by step

4) How to enable sa user in MSSql
https://www.youtube.com/watch?v=Ckb-YoHsuOE

5) ### How to map stored procedure in EF
https://stackoverflow.com/questions/43821023/stored-procedure-in-entity-framework-database-first-approach
