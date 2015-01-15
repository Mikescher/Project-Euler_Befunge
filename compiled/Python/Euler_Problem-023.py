# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="Ah+LCAAAAAAABACT7+ZgAAEWhrd3z+Y1OQgc+BieKaI3YVpiqrDTmWX8SVecJ+991ynMf78x18tl1daNt/r/6xta8ykrcR++lyP/YbIOIwPR4IHXu7/1a3eE/Dbb9X1n9u+M2vmLf76+8yg1MNVXMzE1d1qqkuOR3Z82Zva0SQdb8P5Ri80rP+vltK8r+mvupXn3bdctyj6kMnl66/RL3Z6PN1wX337iq2zsY08NVzu7y7kdxpOrN8atKuEpnixVv2ei524PI98dO/VMptvE3ug/HPJjvfzt+idfMgM9C6ZW1GplXOFd+MOErzXujVrvyTtZC2W5cuMzkhfOFctSun733e5/3E/u7f8QfmvePRuzuf5iarUGZ87O5H9wIfDyzLffi9Wnsh8uLwji146JvWN1ebsSr88b57Q3zkc33d24a+9Gv+kbJl+x8ljbrfr46cJndTsMw7vrq+w8emu7bu7oDU8+xxTW0MnAAAB8+2yueAEAAA=="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<400 and y<88):
        return g[y*400 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<400 and y<88):
        g[y*400 + x]=v;
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
    return (13)if(sp()!=0)else(27)
def _1():
    return (12)if(sp()!=0)else(14)
def _2():
    return (26)if(sp()!=0)else(15)
def _3():
    return (8)if(sp()!=0)else(21)
def _4():
    return (9)if(sp()!=0)else(16)
def _5():
    return (18)if(sp()!=0)else(20)
def _6():
    return (22)if(sp()!=0)else(24)
def _7():
    return (23)if(td(gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1)),2))else(25)
def _8():
    return (17)if(tm(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(1)),2))else(16)
def _9():
    return (19)if(tm(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+(1)),2))else(18)
def _10():
    gw(1,0,400)
    gw(0,0,30000)
    sa((gr(0,0))-(1))
    sa((gr(0,0))-(1))
    gw(2,0,(gr(0,0))-(1))
    return 11
def _11():
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    sa(td(sp(),v0))
    return 12
def _12():
    sa(sr())
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    return 0
def _13():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 1
def _14():
    sp()
    sa(gr(2,0))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+(1),sp())
    sa(sr())
    return 2
def _15():
    gw(0,1,0)
    gw(4,0,gr(0,0))
    sp()
    sp()
    return 16
def _16():
    sa((gr(4,0))-(1))
    gw(4,0,(gr(4,0))-(1))
    return 3
def _17():
    gw(5,0,(gr(4,0))+(1))
    return 18
def _18():
    sa((gr(5,0))-(1))
    gw(5,0,(gr(5,0))-(1))
    return 4
def _19():
    sa((1)if(((gr(4,0))+(gr(5,0)))>(gr(0,0)))else(0))
    return 5
def _20():
    gw(tm((gr(4,0))+(gr(5,0)),gr(1,0)),(td((gr(4,0))+(gr(5,0)),gr(1,0)))+(1),(tm(gr(tm((gr(4,0))+(gr(5,0)),gr(1,0)),(td((gr(4,0))+(gr(5,0)),gr(1,0)))+(1)),2))+(2))
    return 18
def _21():
    gw(8,0,0)
    gw(2,0,gr(0,0))
    return 22
def _22():
    gw(2,0,(gr(2,0))-(1))
    return 7
def _23():
    sa(gr(2,0))
    return 6
def _24():
    print(gr(8,0),end="",flush=True)
    return 28
def _25():
    gw(8,0,(gr(8,0))+(gr(2,0)))
    return 23
def _26():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(sr())
    gw(2,0,sp())
    return 11
def _27():
    sa(sr())
    gw(3,0,sp())
    sa(sp()+sp());
    sa((gr(3,0))-(1))
    sa((gr(3,0))-(1))
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27]
c=10
while c<28:
    c=m[c]()