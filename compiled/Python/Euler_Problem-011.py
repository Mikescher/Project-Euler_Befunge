#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADlmM1uIzcQhF+lIWcvGjjmP4eCoAR5DsPOba466bQPv1+1tJtdIM5KCJhLiLFEzlBgTXV1NemLfd8u9kg7PjT7oXbalV16OezjcwhnO1kIYTuY37RP"
  + "u992y+tt8BIXO5vp8XWuPb29X5YP2zzId7T/G6ywWkiWko1uebVYiZOVoM9Ov1jgs1tfrSaLySr3u42oH34WrKe/af8eVhm6xhCU2G2NFkHQrQVbu+5wf6xWsjXmrAJa"
  + "m7Uk3BNhgQNYOVrPVqv1YbFYAmi2HoWpdavZ1tUyFGZNjtkyyOpMWISmw0e1lMUEJEXQJHGTGK7iJkTLSR2A5q6gA4s4ToSFqqAq+pI1ipsGN8Qr2vDla9Gc4oJLq7Vm"
  + "OYuwdWoQoaR0kQFPKExhquKjFEkeBEQQvYNvBV+wXCW4q/YnwgIQikZhYqIolBAWIaYpMW/aGuKMWEMVCZF9Zp8Ki1VBAA3NnaK5CyRXG9EcxfJQJzhE9AQyZS4vMFdb"
  + "RQlYV/kTS5KPhBKgw92B8HENIpiVocrHIuUBtKepsKJ0ozQc7p+4ZZOwIAyRSUlFN1uUzmS5RSmi/lSDgIzozoS2yDjJ3PMRuydSwTNOxpGUrYI4NBmzGFPZYjHUQwTx"
  + "KoKVHRa5eY0sUUvOlqAX9UXtsLWqEsx0+eaGGVRYwIR7IR2KoIAWXfhncZsl3ADF28AnlFNrYhwKEwbRXPXDbUwWv7r8kztn8zrdVaSDSx4uy1SDUOlNyv/1quiqTCSy"
  + "EMawutMyTH5RMRF76rI60nZmEN3BoWp1EM1Ni+SX3XudQf50oAc/UzHIquLVNxRz2SrOByHDvlNVBlCtUTcBBR+2Li91pWcvjkDHRPJUtuTvQ2tQmwHB7iXlm22yPAHl"
  + "6ZpuJYgE7EVvwvw4G5Z4qiJDJZmNQ9BOprttUme061ql+tU3GoCunqfk48wgRhVdVeIo1V/zv7nqtbHJwoTFsztVZrh9kLwS3EyDuJxDeI77w55KQzvHZYm1hnPw78i4"
  + "1ueosY+G9+GTqSGG44NHjBO/vussetLBr5b9p7yPyyudl7Jsu7B7rmm//+tZ+uHZ8vXB4+fE0y+nKx3/DOvzPdjVnNXDxsF1KS9w+7rs/tg9ytbb+9vTn1uIh+MH2L4e"
  + "1E+89O1MfUpJH2EbyyFsOZzjVojYjRgCK74aX2ED0dLCBnlVM7eFpxrTY8LppzMupnU4nrPi0+X921Gdg3oM26/2+/evwh9vcy99H7Yjem3LFsoW2jlUenkLdVs0FsUM"
  + "jm/i5UpWmPivjB/az9na7/dv/xGYb+3uBY8f8/QFUdxTbEkSAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<151 and y<31):
        return g[y*151 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<151 and y<31):
        g[y*151 + x]=v;
def td(a,b):
    return bool(random.getrandbits(1))
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(0,0,675)
    return 1
def _1():
    global t0
    gw((tm(gr(0,0),26))+63,(td(gr(0,0),26))+1,0)
    t0=gr(0,0)
    gw(0,0,gr(0,0)-1)
    return 2
def _2():
    global t0
    return (1)if((t0)!=0)else(3)
def _3():
    gw(1,0,0)
    gw(9,0,0)
    gw(9,1,-1)
    gw(10,0,1)
    gw(10,1,-1)
    gw(11,0,1)
    gw(11,1,0)
    gw(0,0,399)
    return 4
def _4():
    global t0
    gw((tm(gr(0,0),20))+66,(td(gr(0,0),20))+4,((gr(((tm(gr(0,0),20))*3)+1,(td(gr(0,0),20))+4)-48)*10)+(gr(((tm(gr(0,0),20))*3)+2,(td(gr(0,0),20))+4)-48))
    t0=gr(0,0)
    gw(0,0,gr(0,0)-1)
    return 5
def _5():
    global t0
    return (4)if((t0)!=0)else(6)
def _6():
    gw(0,0,399)
    return 7
def _7():
    gw(2,0,2)
    return 8
def _8():
    global t0
    global t1
    global t2
    global t3
    global t4
    sa(gr(2,0)+9)
    gw(3,0,gr(gr(2,0)+9,0))
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    gw(4,0,t0)
    t0=gr(0,0)
    gw(5,0,tm(gr(0,0),20))
    t0=td(t0,20)
    gw(6,0,t0)
    t0=gr(gr(5,0)+66,gr(6,0)+4)
    gw(5,0,gr(5,0)+gr(3,0))
    gw(6,0,gr(6,0)+gr(4,0))
    t1=gr(gr(5,0)+66,gr(6,0)+4)
    gw(5,0,gr(5,0)+gr(3,0))
    gw(6,0,gr(6,0)+gr(4,0))
    t2=gr(gr(5,0)+66,gr(6,0)+4)
    gw(5,0,gr(5,0)+gr(3,0))
    gw(6,0,gr(6,0)+gr(4,0))
    t3=gr(gr(5,0)+66,gr(6,0)+4)
    gw(5,0,gr(5,0)+gr(3,0))
    gw(6,0,gr(6,0)+gr(4,0))
    t4=t2*t3
    t2=t1*t4
    t1=t0*t2
    return (12)if(t1>gr(1,0))else(9)
def _9():
    global t0
    t0=gr(2,0)
    gw(2,0,gr(2,0)-1)
    return (8)if((t0)!=0)else(10)
def _10():
    global t0
    t0=gr(0,0)
    gw(0,0,gr(0,0)-1)
    return (7)if((t0)!=0)else(11)
def _11():
    print(gr(1,0),end="",flush=True)
    return 13
def _12():
    global t1
    gw(1,0,t1)
    return 9
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()