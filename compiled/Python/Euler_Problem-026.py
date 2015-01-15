# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADtVLsOgzAM/JU0gaWIchYEQVRF/ZAKOlTymikT/fe6MICqqFs7VJyU2HL8uMvgqL4Ps2PHjr/HD1aJ8vqugaAfuju2COjk9AhvCyeqmGATCqoYYDT5Yhj2nJrRgr2rEbwjuXCV5Jzwqqmip0ZGWok3CmxtcazlVWIWTIXEmzkxX0xFBR+mtJIOfLos/hRAzpXEICG55RRFIqMWkWM0N0bvSk7IUCkdwziYgHbu2ypvVLb5lGH119os1eYjnvF4IR1ABgAA"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<100 and y<16):
        return g[y*100 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<100 and y<16):
        g[y*100 + x]=v;
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
    return (6)if(sp()!=0)else(13)
def _1():
    return (7)if(sp()!=0)else(8)
def _2():
    return (9)if((0)if((gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+(1)))!=0)else(1))else(10)
def _3():
    return (12)if((1)if(((gr(5,0))-(gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+(1))))>(gr(9,0)))else(0))else(11)
def _4():
    gw(0,0,100)
    gw(6,0,1000)
    gw(8,0,0)
    gw(9,0,0)
    return 5
def _5():
    sa((gr(6,0))-(1))
    gw(6,0,(gr(6,0))-(1))
    return 0
def _6():
    sa(gr(6,0))
    gw(3,0,gr(6,0))
    sa(sr())
    gw(1,0,sp())
    return 7
def _7():
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(0,0))
    v0=sp()
    sa(tm(sp(),v0))
    sa((td(gr(1,0),gr(0,0)))+(1))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa((gr(1,0))-(1))
    sa((gr(1,0))-(1))
    gw(1,0,(gr(1,0))-(1))
    return 1
def _8():
    gw(4,0,1)
    gw(5,0,0)
    gw(4,0,tm((gr(4,0))*(10),gr(3,0)))
    gw(5,0,(gr(5,0))+(1))
    sp()
    return 2
def _9():
    gw(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+(1),gr(5,0))
    gw(4,0,tm((gr(4,0))*(10),gr(3,0)))
    gw(5,0,(gr(5,0))+(1))
    return 2
def _10():
    sa((gr(5,0))-(gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+(1))))
    return 3
def _11():
    sp()
    return 5
def _12():
    gw(9,0,sp())
    gw(8,0,gr(3,0))
    return 5
def _13():
    print(gr(8,0),end="",flush=True)
    return 14
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=4
while c<14:
    c=m[c]()