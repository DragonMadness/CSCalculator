```bash
student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo
$ git init
Initialized empty Git repository in C:/Users/student.MGOK/Desktop/git_repo/.git/

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git pull https://github.com/DragonMadness/CSCalculator.git
remote: Enumerating objects: 18, done.
remote: Counting objects: 100% (18/18), done.
remote: Compressing objects: 100% (14/14), done.
remote: Total 18 (delta 5), reused 17 (delta 4), pack-reused 0
Unpacking objects: 100% (18/18), 6.65 KiB | 7.00 KiB/s, done.
From https://github.com/DragonMadness/CSCalculator
 * branch            HEAD       -> FETCH_HEAD

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git checkout master
Already on 'master'

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git add .

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git commit "added readme"
error: pathspec 'added readme' did not match any file(s) known to git

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git commit master "added readme"
error: pathspec 'master' did not match any file(s) known to git
error: pathspec 'added readme' did not match any file(s) known to git

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git commit -m "added readme"
[master 4d70188] added readme
 Committer: student student <student@mgok.local>
Your name and email address were configured automatically based
on your username and hostname. Please check that they are accurate.
You can suppress this message by setting them explicitly. Run the
following command and follow the instructions in your editor to edit
your configuration file:

    git config --global --edit

After doing this, you may fix the identity used for this commit with:

    git commit --amend --reset-author

 1 file changed, 11 insertions(+)
 create mode 100644 readme.md

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git remote add origin https://github.com/DragonMadness/CSCalculator.git

student@DESKTOP-94LUR91 MINGW64 ~/Desktop/git_repo (master)
$ git push origin master
Enumerating objects: 4, done.
Counting objects: 100% (4/4), done.
Delta compression using up to 4 threads
Compressing objects: 100% (3/3), done.
Writing objects: 100% (3/3), 455 bytes | 455.00 KiB/s, done.
Total 3 (delta 1), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100% (1/1), completed with 1 local object.
To https://github.com/DragonMadness/CSCalculator.git
   5552965..4d70188  master -> master
```
