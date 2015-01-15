# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACNUMtqw0AM/JUBbS82TkdOFoowJh9i4t72qtOe8vHRuqXkYULnIMTMrjQjNSrNPef81XUdTz4ri/ZmSuepDGTBInUNivQlaRMWaxKCTonHcjjjBZe/riJNv+2sAgqiuqATmKAKMN39q2uVoehQxrARuzWayUfqVNeL2Gefsyt7DdFb+QjCHkc0JMwcWw6ODioKBlx/PLx63XONvcebPFtEXr4jPI9e3037z5btNny2v4MbijFYE6oBAAA="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<71 and y<6):
        return g[y*71 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<71 and y<6):
        g[y*71 + x]=v;
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
    return (8)if(sp()!=0)else(16)
def _1():
    return (9)if(sp()!=0)else(10)
def _2():
    return (5)if(sp()!=0)else(12)
def _3():
    return (14)if(sp()!=0)else(13)
def _4():
    return (8)if(sp()!=0)else(17)
def _5():
    return (15)if((gr(gr(0,2),1))-(gr((gr(0,1))-(gr(0,2)),1)))else(11)
def _6():
    gw(0,0,1)
    gw(1,0,1)
    gw(0,4,1000)
    return 7
def _7():
    sa((gr(1,0))+(1))
    sa((gr(1,0))+(1))
    gw(1,0,(gr(1,0))+(1))
    sa(gr(0,4))
    v0=sp()
    sa(sp()-v0)
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 0
def _8():
    gw(0,1,1)
    sa(sp()*sp());
    sa(sr())
    return 9
def _9():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    gw(gr(0,1),1,sp())
    gw(0,1,(gr(0,1))+(1))
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 1
def _10():
    gw(0,2,1)
    sp()
    return 5
def _11():
    sa((gr(0,2))+(1))
    gw(0,2,(gr(0,2))+(1))
    sa(gr(0,1))
    v0=sp()
    sa(sp()-v0)
    return 2
def _12():
    sa(sr())
    sa(gr(0,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 3
def _13():
    gw(0,3,sp())
    return 7
def _14():
    sp()
    return 7
def _15():
    sp()
    return 7
def _16():
    sa(1)
    sa(sp()+sp());
    sa(sr())
    gw(0,0,sp())
    gw(1,0,1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp()
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(0,4))
    v0=sp()
    sa(sp()-v0)
    return 4
def _17():
    sp()
    sp()
    print(gr(0,3),end="",flush=True)
    return 18
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17]
c=6
while c<18:
    c=m[c]()