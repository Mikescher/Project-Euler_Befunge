#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADtl81uG0cQhF+FYJyLaCf9O90tJEIeJHBy45UnPb+/kS0ECAwo1vKYAYYr7nC3pquraqDz81nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRjPp2Pj"
  + "SVOuvPNpyRW0689/8vHrXK5nOX964KZeHlnmR5+C+dPzX48t17+5fnjKl1U25V9XTsPGTk8lV7n2erh85K9+fez8+/kjT/7yxz/Yn//jHn9jfvixR773ineNp/7K+eaH"
  + "ei+PdvpG0umVJVbmIrcXrk6brG8Vf37PZr+/0de7n+n9Ra9Sbz/yzvHDe74r+v/j36NcV2mtdHWXZTE6Zqk6qyJsZUWFeabvlRiP45izpj1NXK0qUpbbMp+sdm1RVoNL"
  + "r4nqTu3w45idvTSXVI+qUUhMRk6Kltdku+ukdbpJtyQEHMdUyxCqgULNTvNeTsbyZY3byFA4oAbRLgHH9fY73xpr9awVTWURaXvSYYrUzhXiwnYUBrSM/bjqHbhdZjaN"
  + "NMy9gWj1dF9Wa2lYW8sKRrOvTULFHMd08eyRslkwiTbpbYRUISQY9lbJTfq41CwB+zhmIRYLK9jr9oHJqRE+dwvHdLZ2p7aCWsar7oCJAa0cawoFQSqOUDPBkcEuZCq3"
  + "ytBZ4ha0dA+vpGUHLCKUVXhhiTrsUjImiuAewo1QtmZKMswddJu+plphtDrQK8bBoanwCsXLXiyjsxf5ZtF2HJOCqCDUK6FZqJO0GzFUi2i2tHphIY30VBGC8A6Ypmt5"
  + "wSZqJXPwjQiCIQfCdxai2aDDlY1mF90+jqlri7Y0aoa+hQ2mxKbLYyUxj1/Jdt1BwULQ5Dtg1ovdyXleHLkgEoEupLoIBPJJDQ8RD0TygoK4Qz/xJh4040DbqjVUqnts"
  + "L0pStxYETygkkwkhfRyTrOG4Eu8kzikUmCD6Bpe+ZG1vzkkNchBpDcFxHLPhVQg8lEQA7NaRu5UBkgg6wp6cAjC8zzvOdrlDP2XrkTyITe7EPsZAxBW2rUkn+X8CISeB"
  + "SyxgnjyOWUohtoZKu+mq7MOE+po0EhRsWcnBaULwcZbinuOYXwA+olORJA0AAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<116 and y<29):
        return g[y*116 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<116 and y<29):
        g[y*116 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
def _0():
    global t0
    gw(0,0,118)
    gw(1,0,20)
    gw(2,0,50)
    gw(3,0,1000)
    gw(4,0,13)
    gw(5,0,0)
    gw(6,0,0)
    gw(7,0,0)
    gw(8,0,0)
    t0=0
    return 1
def _1():
    global t0
    gw(6,0,gr(5,0))
    t0=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48
    return 2
def _2():
    global t1
    t1=gr(6,0)+1
    gw(6,0,gr(6,0)+1)
    t1=t1-gr(5,0)
    t1=t1-gr(4,0)

    return (3)if((t1)!=0)else(4)
def _3():
    global t0
    t0=t0*(gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48)
    return 2
def _4():
    global t0
    return (10)if(t0>gr(8,0))else(5)
def _5():
    global t0
    t0=gr(5,0)+1
    gw(5,0,gr(5,0)+1)
    t0=t0-gr(3,0)

    return (1)if((t0)!=0)else(6)
def _6():
    gw(7,0,9)
    return 7
def _7():
    sys.stdout.write(chr(gr(gr(7,0),0)+48))
    sys.stdout.flush()


    return (9)if((gr(7,0)-8-gr(4,0))!=0)else(8)
def _8():
    sys.stdout.write(chr(61))
    sys.stdout.flush()

    sys.stdout.write(str(gr(8,0))+" ")
    sys.stdout.flush()
    return 13
def _9():
    gw(7,0,gr(7,0)+1)
    return 7
def _10():
    global t0
    gw(8,0,t0)
    gw(6,0,0)
    return 11
def _11():
    global t0
    gw(gr(6,0)+9,0,gr(tm(gr(6,0)+gr(5,0),gr(2,0)),(td(gr(6,0)+gr(5,0),gr(2,0)))+9)-48)
    t0=gr(6,0)+1
    gw(6,0,gr(6,0)+1)
    t0=t0-gr(4,0)
    return 12
def _12():
    global t0
    return (11)if((t0)!=0)else(5)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()
