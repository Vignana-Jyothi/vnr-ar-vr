

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

(failed)

## Do more instllations 
sudo apt install libgtk2.0-0 libnss3 libgconf-2-4 libasound2 libxss1

sudo dpkg -i gconf2-common_3.2.6-4ubuntu1_all.deb
sudo dpkg -i libgconf-2-4_3.2.6-4ubuntu1_amd64.deb
sudo apt --fix-broken install
wget http://archive.ubuntu.com/ubuntu/pool/universe/g/gconf/gconf2-common_3.2.6-4ubuntu1_all.deb
sudo dpkg -i gconf2-common_3.2.6-4ubuntu1_all.deb
wget http://archive.ubuntu.com/ubuntu/pool/universe/g/gconf/libgconf-2-4_3.2.6-4ubuntu1_amd64.deb
sudo dpkg -i libgconf-2-4_3.2.6-4ubuntu1_amd64.deb
sudo apt --fix-broken install
APPIMAGE_EXTRACT_AND_RUN=1 unityhub