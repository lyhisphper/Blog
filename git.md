## 标签操作
```
// 查看分支
 git branch

// 切换分支
git checkout master

// 查看标签
git tag

// 历史提交（commit）列表
git log --pretty=oneline --abbrev-commit

// 给历史提交打标签
git tag V0.9 24f92f4
// 给历史提交打标签（带有说明）
git tag -a V0.1 -m "version 0.1 released" 1186b5e

// 查看标签信息
git show <tagname>

// 删除标签
git tag -d V0.1
// 删除远程标签
git tag -d V0.9
git push origin :refs/tags/V0.9

// 推送标签到远程
 git push origin V1.0

// 推送所有标签到远程
git push origin --tags
```
## 分支操作
```
//  查看本地分支
 git branch 

// 查看远程端的查分支命令
git branch  -a  

// 新建分支
git branch newBranch

// 切换到你的新分支: 
git checkout newBranch

// 创建并切换到新分支
git checkout -b newBranch

// 将新分支推送到远程：
git push origin newBranch
git push origin newBranch:newBranch

 // 删除本地分支
git branch -d newBranch

// 删除远程分支
git push origin :newBranch
git branch -r -d origin/branch1

本地分支与远程分支关联
git branch --set-upstream-to origin/dev0628

查看本地分支与远程分支关联关系
git branch -vv
```