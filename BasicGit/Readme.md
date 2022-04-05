# GIT Basics  

## Materials
[Git: Getting Started](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)
## Basic Git Commands
1. Initialize a repository : `git init`
1. Check the status of the repository : `git status`
1. Add files to the staging area : `git add .`
1. Commit the changes : `git commit -m "message"`
1. Push the changes to a remote repository : `git push origin main`
1. Pull the changes from a remote repository : `git pull origin main`
1. Clone a remote repository : `git clone <repository-url>`

## Git Configuration
1. Set the user name : `git config --global user.name "<your name here>"`
1. Set the user email : `git config --global user.email "<your email here>"`

## Check the logs
1. Check the logs of the last commit : `git log`
1. Check the logs of the last commit : `git log --oneline`

## Check the diiferences
1. Check the differences between two commits : `git diff <commit-id> <commit-id>`
1. Check the differences of files between two commits : `git diff <commit-id> <commit-id> <file-name>`
1. Check the difference between last commit and the current state : `git diff <filename>`

## Branches
1. Create a new branch : `git branch <branch-name>`
1. Check the status of the branch : `git branch`
1. Switch to new branch : `git checkout <branch-name>`

## Merge branches
1. Merge branches : `git merge --no-ff <branch-name>`

## Revert changes
1. Revert changes : `git revert <commit-id>`
1. Stash changes : `git stash`
1. Unstash changes : `git stash pop`
1. Reset changes : `git reset --hard`
1. Reset changes : `git reset --soft`
1. Unstage files : `git restore --staged .`

## Add gitignore
1. Add a .gitignore file : `touch .gitignore`
1. Add a .gitignore file : `echo "*.log" >> .gitignore`
1. Clear the cache : 'git rm -r --cached .'
