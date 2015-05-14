# compiled with BefunCompile v1.0.5 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABACNUMtqw0AM/JUBbS82TkdOFoowJh9i4t72qtOe8vHRuqXkYULnIMTMrjQjNSrNPef81XUdTz4ri/ZmSuepDGTBInUNivQlaRMWaxKCTonHcjjjBZe/"
  + "riJNv+2sAgqiuqATmKAKMN39q2uVoehQxrARuzWayUfqVNeL2Gefsyt7DdFb+QjCHkc0JMwcWw6ODioKBlx/PLx63XONvcebPFtEXr4jPI9e3037z5btNny2v4MbijFY"
  + "E6oBAAA=")
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
    gw(0,0,1)
    gw(1,0,1)
    gw(0,4,1000)
    return 1
def _1():
    sa(gr(1,0)+1)
    sa(gr(1,0)+1)
    gw(1,0,gr(1,0)+1)
    sa(gr(0,4))
    v0=sp()
    sa(sp()-v0)
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return (4)if(sp()!=0)else(2)
def _2():
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
    return (4)if(sp()!=0)else(3)
def _3():
    sp()
    sp()
    print(gr(0,3),end="",flush=True)
    return 14
def _4():
    gw(0,1,1)
    sa(sp()*sp());
    sa(sr())
    return 5
def _5():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    gw(gr(0,1),1,sp())
    gw(0,1,gr(0,1)+1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 6
def _6():
    return (5)if(sp()!=0)else(7)
def _7():
    gw(0,2,1)
    sp()
    return 8
def _8():
    return (13)if(gr(gr(0,2),1)-gr(gr(0,1)-gr(0,2),1))else(9)
def _9():
    sa(gr(0,2)+1)
    gw(0,2,gr(0,2)+1)
    sa(gr(0,1))
    v0=sp()
    sa(sp()-v0)
    return (8)if(sp()!=0)else(10)
def _10():
    sa(sr())
    sa(gr(0,3))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (11)if(sp()!=0)else(12)
def _11():
    sp()
    return 1
def _12():
    gw(0,3,sp())
    return 1
def _13():
    sp()
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()