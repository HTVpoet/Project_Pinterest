"use strict";(self.webpackChunkpicsta=self.webpackChunkpicsta||[]).push([[659],{73112:function(e,n,t){t.d(n,{$W:function(){return Z},K:function(){return j},V7:function(){return v},et:function(){return x}});var r=t(24076),i=t(67478),a=t(1413),o=t(45987),s=t(88564),l=t(61113),c=t(46417),u=["title","description"],d=(0,s.ZP)("div")((function(e){return{height:"100%",display:"flex",textAlign:"center",alignItems:"center",flexDirection:"column",justifyContent:"center",padding:e.theme.spacing(8,2)}}));function h(e){var n=e.title,t=e.description,r=(0,o.Z)(e,u);return(0,c.jsxs)(d,(0,a.Z)((0,a.Z)({},r),{},{children:[(0,c.jsx)(l.Z,{variant:"h5",gutterBottom:!0,children:n}),t&&(0,c.jsx)(l.Z,{variant:"body2",sx:{color:"text.secondary"},children:t})]}))}function x(e){var n=e.isNotFound;return(0,c.jsx)(c.Fragment,{children:n?(0,c.jsx)(r.Z,{children:(0,c.jsx)(i.Z,{colSpan:9,children:(0,c.jsx)(h,{title:"No Data",sx:{"& span.MuiBox-root":{height:160}}})})}):(0,c.jsx)(r.Z,{children:(0,c.jsx)(i.Z,{colSpan:9,sx:{p:0}})})})}var f=t(47131),g=t(42593),p=t(28100);function v(e){var n=e.actions,t=e.open,r=e.onClose,i=e.onOpen;return(0,c.jsxs)(c.Fragment,{children:[(0,c.jsx)(f.Z,{onClick:i,children:(0,c.jsx)(g.Z,{icon:"eva:more-vertical-fill",width:20,height:20})}),(0,c.jsx)(p.Z,{open:Boolean(t),anchorEl:t,onClose:r,anchorOrigin:{vertical:"top",horizontal:"left"},transformOrigin:{vertical:"top",horizontal:"right"},arrow:"right-top",sx:{mt:-1,width:160,"& .MuiMenuItem-root":{px:1,typography:"body2",borderRadius:.75,"& svg":{mr:2,width:20,height:20}}},children:n})]})}function Z(e){var n=e.emptyRows,t=e.height;return n?(0,c.jsx)(r.Z,{sx:(0,a.Z)({},t&&{height:t*n}),children:(0,c.jsx)(i.Z,{colSpan:9})}):null}var m=t(23477);function j(e){var n=e.headLabel,t=e.sx;return(0,c.jsx)(m.Z,{sx:t,children:(0,c.jsx)(r.Z,{children:n.map((function(e){return(0,c.jsx)(i.Z,{align:e.align||"left",sx:{width:e.width,minWidth:e.minWidth},children:e.label},e.id)}))})})}},66429:function(e,n,t){t.d(n,{ZP:function(){return a},fQ:function(){return o}});var r=t(70885),i=t(47313);function a(e){var n=(0,i.useState)((null===e||void 0===e?void 0:e.defaultDense)||!1),t=(0,r.Z)(n,2),a=t[0],o=t[1],s=(0,i.useState)((null===e||void 0===e?void 0:e.defaultOrderBy)||"name"),l=(0,r.Z)(s,2),c=l[0],u=l[1],d=(0,i.useState)((null===e||void 0===e?void 0:e.defaultOrder)||"asc"),h=(0,r.Z)(d,2),x=h[0],f=h[1],g=(0,i.useState)((null===e||void 0===e?void 0:e.defaultCurrentPage)||0),p=(0,r.Z)(g,2),v=p[0],Z=p[1],m=(0,i.useState)((null===e||void 0===e?void 0:e.defaultRowsPerPage)||5),j=(0,r.Z)(m,2),w=j[0],P=j[1],S=(0,i.useState)((null===e||void 0===e?void 0:e.defaultSelected)||[]),b=(0,r.Z)(S,2),y=b[0],C=b[1];return{dense:a,order:x,page:v,setPage:Z,orderBy:c,rowsPerPage:w,selected:y,setSelected:C,onSelectRow:function(e){var n=y.indexOf(e),t=[];-1===n?t=t.concat(y,e):0===n?t=t.concat(y.slice(1)):n===y.length-1?t=t.concat(y.slice(0,-1)):n>0&&(t=t.concat(y.slice(0,n),y.slice(n+1))),C(t)},onSelectAllRows:function(e,n){C(e?n:[])},onSort:function(e){""!==e&&(f(c===e&&"asc"===x?"desc":"asc"),u(e))},onChangePage:function(e,n){Z(n)},onChangeDense:function(e){o(e.target.checked)},onChangeRowsPerPage:function(e){P(parseInt(e.target.value,10)),Z(0)}}}function o(e,n,t){return e>0?Math.max(0,(1+e)*n-t):0}},14659:function(e,n,t){t.r(n),t.d(n,{default:function(){return A}});var r=t(15861),i=t(70885),a=t(64687),o=t.n(a),s=t(86248),l=t(47313),c=t(97890),u=t(43265),d=t(73428),h=t(19536),x=t(51629),f=t(66835),g=t(57861),p=t(57829),v=t(97649),Z=t(48175),m=t(11338),j=t(66429),w=t(71361),P=t(62677),S=t(73112),b=t(1413),y=t(24076),C=t(67478),k=t(48119),N=t(61113),R=t(51405),F=t(42593),O=t(46417);function W(e){var n=e.row,t=e.onDeleteRow,r=n.fullName,a=n.roleName,o=n.email,s=n.avatarUrl,c=n.userStatusName,u=(0,l.useState)(null),d=(0,i.Z)(u,2),h=d[0],x=d[1],f=function(){x(null)};return(0,O.jsxs)(y.Z,{children:[(0,O.jsxs)(C.Z,{align:"center",sx:{display:"flex",alignItems:"center"},children:[(0,O.jsx)(k.Z,{alt:r,src:s,sx:{mr:2}}),(0,O.jsx)(N.Z,{variant:"subtitle2",noWrap:!0,children:r})]}),(0,O.jsx)(C.Z,{align:"center",children:a}),(0,O.jsx)(C.Z,{align:"center",sx:{textTransform:"capitalize"},children:o}),(0,O.jsx)(C.Z,{align:"center",children:(0,O.jsx)(F.Z,{icon:"\u0110\xe3 k\xedch ho\u1ea1t"===c?"eva:checkmark-circle-fill":"solar:forbidden-outline",sx:(0,b.Z)({width:20,height:20,color:"success.main"},!("\u0110\xe3 k\xedch ho\u1ea1t"===c)&&{color:"error.main"})})}),(0,O.jsx)(C.Z,{align:"right",children:(0,O.jsx)(S.V7,{open:h,onOpen:function(e){x(e.currentTarget)},onClose:f,actions:(0,O.jsx)(O.Fragment,{children:(0,O.jsxs)(R.Z,{onClick:function(){t(),f()},sx:{color:"error.main"},children:[(0,O.jsx)(F.Z,{icon:"eva:trash-2-outline"}),"Delete"]})})})})]})}var B=t(35898),D=t(15082),z=t(41727);function E(e){var n=e.filterName,t=e.onFilterName;return(0,O.jsx)(B.Z,{spacing:2,direction:{xs:"column",sm:"row"},sx:{py:2.5,px:3},children:(0,O.jsx)(D.Z,{fullWidth:!0,value:n,onChange:function(e){return t(e.target.value)},placeholder:"Search user...",InputProps:{startAdornment:(0,O.jsx)(z.Z,{position:"start",children:(0,O.jsx)(F.Z,{icon:"eva:search-fill",sx:{color:"text.disabled",width:20,height:20}})})}})})}var I=t(52643),M=[{id:"fullName",label:"Full name",align:"center"},{id:"roleName",label:"Role",align:"center"},{id:"email",label:"Email",align:"center"},{id:"userStatusName",label:"Status",align:"center"},{id:"",label:"Action",align:"right"}];function A(){var e=(0,j.ZP)(),n=e.page,t=e.order,a=e.orderBy,b=e.rowsPerPage,y=e.setPage,C=e.onChangePage,k=e.onChangeRowsPerPage,N=(0,m.Z)().themeStretch,R=(0,c.s0)(),F=(0,l.useState)([]),B=(0,i.Z)(F,2),D=B[0],z=B[1],A=(0,l.useState)(""),K=(0,i.Z)(A,2),L=K[0],Q=K[1],T=function(){var e=(0,r.Z)(o().mark((function e(){var t,r;return o().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:if(e.prev=0,L){e.next=8;break}return e.next=4,(0,I.Y8)({pageNumber:n+1,pageSize:b});case 4:t=e.sent,z(t.data),e.next=12;break;case 8:return e.next=10,(0,I.gs)({pageNumber:n+1,pageSize:b,name:L});case 10:r=e.sent,z(r.data);case 12:e.next=17;break;case 14:e.prev=14,e.t0=e.catch(0),console.error("Error fetching data:",e.t0);case 17:case"end":return e.stop()}}),e,null,[[0,14]])})));return function(){return e.apply(this,arguments)}}();(0,l.useEffect)((function(){T()}),[L,n,b]);var U=function(){var e=(0,r.Z)(o().mark((function e(n){return o().wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,(0,I.h8)(n);case 2:e.sent,R(0);case 4:case"end":return e.stop()}}),e)})));return function(n){return e.apply(this,arguments)}}(),V=!D.length&&!!L;return(0,O.jsx)(w.Z,{title:"Manage Users",children:(0,O.jsx)(u.Z,{maxWidth:!N&&"lg",children:(0,O.jsxs)(d.Z,{children:[(0,O.jsx)(h.Z,{}),(0,O.jsx)(E,{filterName:L,onFilterName:function(e){Q(e),y(0)}}),(0,O.jsx)(P.Z,{children:(0,O.jsx)(x.Z,{sx:{minWidth:800,position:"relative"},children:(0,O.jsxs)(f.Z,{children:[(0,O.jsx)(S.K,{order:t,orderBy:a,headLabel:M}),(0,O.jsxs)(g.Z,{children:[D.map((function(e){return(0,O.jsx)(W,{row:e,onDeleteRow:function(){return U(e.id)},onEditRow:function(){return n=e.name,void R(Z.v.user.edit((0,s.o)(n)));var n}},e.id)})),(0,O.jsx)(S.$W,{emptyRows:(0,j.fQ)(n,b,D.length)}),(0,O.jsx)(S.et,{isNotFound:V})]})]})})}),(0,O.jsx)(p.Z,{sx:{position:"relative"},children:(0,O.jsx)(v.Z,{rowsPerPageOptions:[5,10,25],component:"div",count:D.length,rowsPerPage:b,page:n,onPageChange:C,onRowsPerPageChange:k})})]})})})}}}]);