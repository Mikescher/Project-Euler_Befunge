#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<299 and y<101):
        return g[y*299 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<299 and y<101):
        g[y*299 + x]=v;
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
    gw(0,0,100)
    gw(2,0,gr(0,0)-1)
    gw(1,0,0)
    return 1
def _1():
    global t0
    global t0
    global t0
    gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48))
    t0=gr(1,0)+1
    gw(1,0,gr(1,0)+1)
    t0=t0-gr(2,0)
    t0=t0-1
    return 2
def _2():
    global t0
    return (1)if((t0)!=0)else(3)
def _3():
    global t0
    global t0
    t0=gr(2,0)
    gw(2,0,gr(2,0)-1)
    gw(1,0,0)
    return (1)if((t0)!=0)else(4)
def _4():
    global t0
    global t0
    t0=gr(0,0)-2
    gw(1,0,gr(0,0)-2)
    gw(2,0,t0)
    return 5
def _5():
    global t0
    sa(gr(gr(1,0),gr(2,0)+1))
    sa(gr(gr(1,0),gr(2,0)+2))
    t0=gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2)
    return (6)if((gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2))>0)else(9)
def _6():
    global t0
    global t0
    global t0
    global t0
    sa(sp()+sp());
    t0=sp()
    gw(gr(1,0),gr(2,0)+1,t0)
    t0=gr(1,0)
    gw(1,0,gr(1,0)-1)
    return (5)if((t0)!=0)else(7)
def _7():
    global t0
    global t1
    global t1
    global t0
    t0=gr(2,0)
    t1=gr(2,0)-1
    gw(2,0,gr(2,0)-1)
    gw(1,0,t1)
    return (5)if((t0)!=0)else(8)
def _8():
    print(gr(0,1),end="",flush=True)
    return 10
def _9():
    global t0
    sa(sp()-t0);
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()