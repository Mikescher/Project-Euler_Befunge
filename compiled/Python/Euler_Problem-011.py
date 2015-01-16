# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADlmM1uIzcQhF+lIWcvGjjmP4eCoAR5DsPOba466bQPv1+1tJtdIM5KCJhLiLFEzlBgTXV1NemLfd8u9kg7PjT7oXbalV16OezjcwhnO1kIYTuY37RPu992y+tt8BIXO5vp8XWuPb29X5YP2zzId7T/G6ywWkiWko1uebVYiZOVoM9Ov1jgs1tfrSaLySr3u42oH34WrKe/af8eVhm6xhCU2G2NFkHQrQVbu+5wf6xWsjXmrAJam7Uk3BNhgQNYOVrPVqv1YbFYAmi2HoWpdavZ1tUyFGZNjtkyyOpMWISmw0e1lMUEJEXQJHGTGK7iJkTLSR2A5q6gA4s4ToSFqqAq+pI1ipsGN8Qr2vDla9Gc4oJLq7VmOYuwdWoQoaR0kQFPKExhquKjFEkeBEQQvYNvBV+wXCW4q/YnwgIQikZhYqIolBAWIaYpMW/aGuKMWEMVCZF9Zp8Ki1VBAA3NnaK5CyRXG9EcxfJQJzhE9AQyZS4vMFdbRQlYV/kTS5KPhBKgw92B8HENIpiVocrHIuUBtKepsKJ0ozQc7p+4ZZOwIAyRSUlFN1uUzmS5RSmi/lSDgIzozoS2yDjJ3PMRuydSwTNOxpGUrYI4NBmzGFPZYjHUQwTxKoKVHRa5eY0sUUvOlqAX9UXtsLWqEsx0+eaGGVRYwIR7IR2KoIAWXfhncZsl3ADF28AnlFNrYhwKEwbRXPXDbUwWv7r8kztn8zrdVaSDSx4uy1SDUOlNyv/1quiqTCSyEMawutMyTH5RMRF76rI60nZmEN3BoWp1EM1Ni+SX3XudQf50oAc/UzHIquLVNxRz2SrOByHDvlNVBlCtUTcBBR+2Li91pWcvjkDHRPJUtuTvQ2tQmwHB7iXlm22yPAHl6ZpuJYgE7EVvwvw4G5Z4qiJDJZmNQ9BOprttUme061ql+tU3GoCunqfk48wgRhVdVeIo1V/zv7nqtbHJwoTFsztVZrh9kLwS3EyDuJxDeI77w55KQzvHZYm1hnPw78i41ueosY+G9+GTqSGG44NHjBO/vussetLBr5b9p7yPyyudl7Jsu7B7rmm//+tZ+uHZ8vXB4+fE0y+nKx3/DOvzPdjVnNXDxsF1KS9w+7rs/tg9ytbb+9vTn1uIh+MH2L4e1E+89O1MfUpJH2EbyyFsOZzjVojYjRgCK74aX2ED0dLCBnlVM7eFpxrTY8LppzMupnU4nrPi0+X921Gdg3oM26/2+/evwh9vcy99H7Yjem3LFsoW2jlUenkLdVs0FsUMjm/i5UpWmPivjB/az9na7/dv/xGYb+3uBY8f8/QFUdxTbEkSAAA="
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
def rd():
    return bool(random.getrandbits(1))
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
    return (7)if(sp()!=0)else(8)
def _1():
    return (9)if(sp()!=0)else(10)
def _2():
    return (13)if(sp()!=0)else(19)
def _3():
    return (18)if(sp()!=0)else(15)
def _4():
    return (11)if(sp()!=0)else(12)
def _5():
    return (17)if(sp()!=0)else(16)
def _6():
    gw(0,0,675)
    return 7
def _7():
    gw((tm(gr(0,0),26))+(63),(td(gr(0,0),26))+(1),0)
    sa(gr(0,0))
    gw(0,0,(gr(0,0))-(1))
    return 0
def _8():
    gw(1,0,0)
    gw(9,0,0)
    gw(9,1,-1)
    gw(10,0,1)
    gw(10,1,-1)
    gw(11,0,1)
    gw(11,1,0)
    gw(0,0,399)
    return 9
def _9():
    gw((tm(gr(0,0),20))+(66),(td(gr(0,0),20))+(4),(((gr(((tm(gr(0,0),20))*(3))+(1),(td(gr(0,0),20))+(4)))-(48))*(10))+((gr(((tm(gr(0,0),20))*(3))+(2),(td(gr(0,0),20))+(4)))-(48)))
    sa(gr(0,0))
    gw(0,0,(gr(0,0))-(1))
    return 1
def _10():
    gw(0,0,399)
    return 11
def _11():
    gw(2,0,2)
    return 12
def _12():
    sa((gr(2,0))+(9))
    gw(3,0,gr((gr(2,0))+(9),0))
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    gw(4,0,sp())
    sa(gr(0,0))
    gw(5,0,tm(gr(0,0),20))
    sa(20)
    v0=sp()
    sa(td(sp(),v0))
    gw(6,0,sp())
    sa(gr((gr(5,0))+(66),(gr(6,0))+(4)))
    gw(5,0,(gr(5,0))+(gr(3,0)))
    gw(6,0,(gr(6,0))+(gr(4,0)))
    sa(gr((gr(5,0))+(66),(gr(6,0))+(4)))
    gw(5,0,(gr(5,0))+(gr(3,0)))
    gw(6,0,(gr(6,0))+(gr(4,0)))
    sa(gr((gr(5,0))+(66),(gr(6,0))+(4)))
    gw(5,0,(gr(5,0))+(gr(3,0)))
    gw(6,0,(gr(6,0))+(gr(4,0)))
    sa(gr((gr(5,0))+(66),(gr(6,0))+(4)))
    gw(5,0,(gr(5,0))+(gr(3,0)))
    gw(6,0,(gr(6,0))+(gr(4,0)))
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 2
def _13():
    gw(1,0,sp())
    return 14
def _14():
    sa(gr(2,0))
    gw(2,0,(gr(2,0))-(1))
    return 3
def _15():
    sa(gr(0,0))
    gw(0,0,(gr(0,0))-(1))
    return 5
def _16():
    print(gr(1,0),end="",flush=True)
    return 20
def _17():
    sa(1)
    return 4
def _18():
    sa(0)
    return 4
def _19():
    sp()
    return 14
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19]
c=6
while c<20:
    c=m[c]()