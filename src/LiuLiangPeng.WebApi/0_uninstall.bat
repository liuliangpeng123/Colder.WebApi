cd /d %~dp0
set serviceName="LiuLiangPeng.Api"
nssm stop %serviceName%
nssm remove %serviceName% confirm