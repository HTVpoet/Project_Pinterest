"use strict";(self.webpackChunkpicsta=self.webpackChunkpicsta||[]).push([[685],{57685:function(e,r,n){n.r(r),n.d(r,{default:function(){return D}});var t=n(47313),i=n(29466),o=n(88564),c=n(43265),a=n(57829),d=n(69099),s=n(61113),u=n(33896),l=n(48175),h=n(71361),f=n(42593),x=n(1413),m=n(15861),p=n(64687),v=n.n(p),g=n(6473),Z=n(34032),j=n(97890),b=n(75627),q=n(1432),y=n(35898),C=n(37843),k=n(51406),w=n(5279),S=n(46417);function V(){var e=(0,j.s0)(),r=(0,Z.Ds)().enqueueSnackbar,n=g.Ry().shape({code1:g.Z_().required("Code is required"),code2:g.Z_().required("Code is required"),code3:g.Z_().required("Code is required"),code4:g.Z_().required("Code is required"),code5:g.Z_().required("Code is required"),code6:g.Z_().required("Code is required")}),i=(0,b.cI)({mode:"onBlur",resolver:(0,q.X)(n),defaultValues:{code1:"",code2:"",code3:"",code4:"",code5:"",code6:""}}),o=i.watch,c=i.control,a=i.setValue,d=i.handleSubmit,s=i.formState,u=s.isSubmitting,h=s.isValid,f=o();(0,t.useEffect)((function(){document.addEventListener("paste",V)}),[]);var p=function(){var n=(0,m.Z)(v().mark((function n(t){return v().wrap((function(n){for(;;)switch(n.prev=n.next){case 0:return n.prev=0,n.next=3,(0,w.fJ)({confirmCode:Object.values(t).join("")});case 3:r("Verify success!"),e(l.E.login,{replace:!0}),n.next=10;break;case 7:n.prev=7,n.t0=n.catch(0),console.error(n.t0);case 10:case"end":return n.stop()}}),n,null,[[0,7]])})));return function(e){return n.apply(this,arguments)}}(),V=function(e){var r,n=(null===e||void 0===e||null===(r=e.clipboardData)||void 0===r?void 0:r.getData("Text"))||"";n=n.split(""),[].forEach.call(document.querySelectorAll("#field-code"),(function(e,r){e.value=n[r];var t="code".concat(r+1);a(t,n[r])}))};return(0,S.jsxs)("form",{onSubmit:d(p),children:[(0,S.jsx)(y.Z,{direction:"row",spacing:2,justifyContent:"center",children:Object.keys(f).map((function(e,r){return(0,S.jsx)(b.Qr,{name:"code".concat(r+1),control:c,render:function(e){var n=e.field;return(0,S.jsx)(C.Z,(0,x.Z)((0,x.Z)({},n),{},{id:"field-code",autoFocus:0===r,placeholder:"-",onChange:function(e){return function(e,r){var n=e.target,t=n.maxLength,i=n.value,o=n.name.replace("code",""),c=Number(o);if(i.length>=t&&c<6){var a=document.querySelector("input[name=code".concat(c+1,"]"));null!==a&&a.focus()}r(e)}(e,n.onChange)},inputProps:{maxLength:1,sx:{p:0,textAlign:"center",width:{xs:36,sm:56},height:{xs:36,sm:56}}}}))}},e)}))}),(0,S.jsx)(k.Z,{fullWidth:!0,size:"large",type:"submit",variant:"contained",loading:u,disabled:!h,sx:{mt:3},children:"Verify"})]})}var _=n(61819),E=(0,o.ZP)("div")((function(e){return{display:"flex",height:"100%",alignItems:"center",padding:e.theme.spacing(12,0)}}));function D(){var e=(0,t.useContext)(_.V),r=e.method,n=e.user;return console.log(r,n),(0,S.jsx)(h.Z,{title:"Verify",sx:{height:1},children:(0,S.jsxs)(E,{children:[(0,S.jsx)(u.Z,{}),(0,S.jsx)(c.Z,{children:(0,S.jsxs)(a.Z,{sx:{maxWidth:480,mx:"auto"},children:[(0,S.jsx)(d.Z,{size:"small",component:i.rU,to:l.E.login,startIcon:(0,S.jsx)(f.Z,{icon:"eva:arrow-ios-back-fill",width:20,height:20}),sx:{mb:3},children:"Back"}),(0,S.jsx)(s.Z,{variant:"h3",paragraph:!0,children:"Please check your email!"}),(0,S.jsx)(s.Z,{sx:{color:"text.secondary"},children:"We have emailed a 6-digit confirmation code to acb@domain, please enter the code in below box to verify your email."}),(0,S.jsx)(a.Z,{sx:{mt:5,mb:3},children:(0,S.jsx)(V,{})})]})})]})})}}}]);