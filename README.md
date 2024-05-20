

Steps
https://docs.unity3d.com/hub/manual/InstallHub.html#install-hub-linux



## Setup
git clone git@github.com:Vignana-Jyothi/vnr-ar-vr.git

cd vnr-ar-vr

wget -qO - https://hub.unity3d.com/linux/keys/public | gpg --dearmor | sudo tee /usr/share/keyrings/Unity_Technologies_ApS.gpg > /dev/null

sudo sh -c 'echo "deb [signed-by=/usr/share/keyrings/Unity_Technologies_ApS.gpg] https://hub.unity3d.com/linux/repos/deb stable main" > /etc/apt/sources.list.d/unityhub.list'

sudo apt update
sudo apt-get install unityhub


## How to start using 

unityhub
