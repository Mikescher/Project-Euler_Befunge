#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABAC9jz0KAjEQha+SnZhmh5hMhogECbZeYrcR0qZK6dkddxVEEGOzrxjmD977mt9AbQMPynCFTDYNus3Jc/XEFW4XwMA1By5yNoRr4wp4sJ7LSFwwxYjm"
  + "cFRNdWla6k5/rOdJD5VDslQ4VCaHMVYnZjIimWcznvpMVuUFgAUm84uA3whQKRkTWXnpjf9N5/2D4NfXX/HVHUV2dgFeAgAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<101 and y<6):
        return g[y*101 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<101 and y<6):
        g[y*101 + x]=v;
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
    sa(99)
    return 1
def _1():
    sa(sr())
    gw(0,3,sp())
    gw(1,3,0)
    gw(2,3,199)
    return 2
def _2():
    global t0
    global t0
    global t0
    global t0
    global t0
    t0=((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3)
    gw((tm(gr(2,3),100))+1,td(gr(2,3),100),(tm(((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3),10))+48)
    t0=td(t0,10)
    gw(1,3,t0)
    t0=gr(2,3)-1
    gw(2,3,gr(2,3)-1)
    t0=(0)if(t0!=0)else(1)
    return 3
def _3():
    global t0
    return (4)if((t0)!=0)else(2)
def _4():
    sa(sp()-1);
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (5)if(sp()!=0)else(1)
def _5():
    global t0
    gw(3,3,199)
    sp()
    t0=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48
    return 6
def _6():
    global t1
    global t1
    global t1
    t1=gr(3,3)
    gw(3,3,gr(3,3)-1)
    t1=(0)if(t1!=0)else(1)
    return (7)if((t1)!=0)else(8)
def _7():
    global t0
    print(t0,end="",flush=True)
    return 9
def _8():
    global t0
    t0=t0+(gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48)
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()