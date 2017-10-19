#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACNUMtqw0AM/JUBbS82TkdOFoowJh9i4t72qtOe8vHRuqXkYULnIMTMrjQjNSrNPef81XUdTz4ri/ZmSuepDGTBInUNivQlaRMWaxKCTonHcjjjBZe/"
  + "riJNv+2sAgqiuqATmKAKMN39q2uVoehQxrARuzWayUfqVNeL2Gefsyt7DdFb+QjCHkc0JMwcWw6ODioKBlx/PLx63XONvcebPFtEXr4jPI9e3037z5btNny2v4MbijFY"
  + "E6oBAAA=")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<71 and y<6):
        return g[y*71 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<71 and y<6):
        g[y*71 + x]=v;
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
    global t0
    t0=gr(1,0)+1
    sa(gr(1,0)+1)
    gw(1,0,gr(1,0)+1)
    t0=t0-gr(0,4)
    sa(gr(0,0))

    return (3)if((t0)!=0)else(2)
def _2():
    sa(sp()+1)

    sa(sr());
    gw(0,0,sp())
    gw(1,0,1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp();
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (3)if((sr()-gr(0,4))!=0)else(12)
def _3():
    gw(0,1,1)
    sa(sp()*sp());

    sa(sr());
    return 4
def _4():
    gw(gr(0,1),1,sr()%10)
    gw(0,1,gr(0,1)+1)
    sa(sp()/10);

    sa(sr());
    return 5
def _5():
    return (4)if(sp()!=0)else(6)
def _6():
    gw(0,2,1)
    sp();
    return 7
def _7():
    return (10)if((gr(gr(0,2),1)-gr(gr(0,1)-gr(0,2),1))!=0)else(8)
def _8():
    global t0
    t0=gr(0,2)+1
    gw(0,2,gr(0,2)+1)
    t0=t0-gr(0,1)

    return (7)if((t0)!=0)else(9)
def _9():
    return (10)if(sr()<gr(0,3))else(11)
def _10():
    sp();
    return 1
def _11():
    gw(0,3,sp())
    sa(0)
    return 10
def _12():
    sys.stdout.write(str(gr(0,3))+" ")
    sys.stdout.flush()

    sp();
    sp();
    return 13
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()
