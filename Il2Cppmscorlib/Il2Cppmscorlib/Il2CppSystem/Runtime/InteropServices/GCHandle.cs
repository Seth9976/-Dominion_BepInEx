using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000457 RID: 1111
	[StructLayout(2)]
	public struct GCHandle
	{
		// Token: 0x06004326 RID: 17190 RVA: 0x00133E00 File Offset: 0x00132000
		// Note: this type is marked as 'beforefieldinit'.
		static GCHandle()
		{
			Il2CppClassPointerStore<GCHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "GCHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCHandle>.NativeClassPtr);
			GCHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, "handle");
			GCHandle.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673013);
			GCHandle.NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673014);
			GCHandle.NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673015);
			GCHandle.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673016);
			GCHandle.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673017);
			GCHandle.NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673018);
			GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673019);
			GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673020);
			GCHandle.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673021);
			GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673022);
			GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673023);
			GCHandle.NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673024);
			GCHandle.NativeMethodInfoPtr_GetTarget_Private_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673025);
			GCHandle.NativeMethodInfoPtr_GetTargetHandle_Private_Static_Int32_Object_Int32_GCHandleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673026);
			GCHandle.NativeMethodInfoPtr_FreeHandle_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673027);
			GCHandle.NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673028);
			GCHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673029);
			GCHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673030);
			GCHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673031);
			GCHandle.NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673032);
			GCHandle.NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, 100673033);
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x00133FE8 File Offset: 0x001321E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358085, XrefRangeEnd = 358086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GCHandle(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr__ctor_Private_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x00134020 File Offset: 0x00132220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358087, RefRangeEnd = 358088, XrefRangeStart = 358086, XrefRangeEnd = 358087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GCHandle(Object value, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06004329 RID: 17193 RVA: 0x00134064 File Offset: 0x00132264
		public unsafe bool IsAllocated
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 358088, RefRangeEnd = 358102, XrefRangeStart = 358088, XrefRangeEnd = 358088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x00134094 File Offset: 0x00132294
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x001340C8 File Offset: 0x001322C8
		public unsafe Object Target
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 358110, RefRangeEnd = 358121, XrefRangeStart = 358102, XrefRangeEnd = 358110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_get_Target_Public_get_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 358122, RefRangeEnd = 358123, XrefRangeStart = 358121, XrefRangeEnd = 358122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00134100 File Offset: 0x00132300
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 358128, RefRangeEnd = 358192, XrefRangeStart = 358123, XrefRangeEnd = 358128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr AddrOfPinnedObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x00134130 File Offset: 0x00132330
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 358193, RefRangeEnd = 358200, XrefRangeStart = 358192, XrefRangeEnd = 358193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle Alloc(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x00134174 File Offset: 0x00132374
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 358201, RefRangeEnd = 358271, XrefRangeStart = 358200, XrefRangeEnd = 358201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle Alloc(Object value, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x001341C4 File Offset: 0x001323C4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 358279, RefRangeEnd = 358352, XrefRangeStart = 358271, XrefRangeEnd = 358279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Free_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x001341EC File Offset: 0x001323EC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 358354, RefRangeEnd = 358365, XrefRangeStart = 358352, XrefRangeEnd = 358354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(GCHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x0013422C File Offset: 0x0013242C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 358382, RefRangeEnd = 358390, XrefRangeStart = 358365, XrefRangeEnd = 358382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator GCHandle(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x0013426C File Offset: 0x0013246C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckCurrentDomain(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x001342AC File Offset: 0x001324AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358390, XrefRangeEnd = 358391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetTarget(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetTarget_Private_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x001342EC File Offset: 0x001324EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358391, XrefRangeEnd = 358392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTargetHandle(Object obj, int handle, GCHandleType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetTargetHandle_Private_Static_Int32_Object_Int32_GCHandleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x0013434C File Offset: 0x0013254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358392, XrefRangeEnd = 358393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeHandle(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_FreeHandle_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00134380 File Offset: 0x00132580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358393, XrefRangeEnd = 358394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetAddrOfPinnedObject(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x001343C0 File Offset: 0x001325C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(GCHandle a, GCHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x0013440C File Offset: 0x0013260C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358394, XrefRangeEnd = 358397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00134450 File Offset: 0x00132650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00134480 File Offset: 0x00132680
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 358382, RefRangeEnd = 358390, XrefRangeStart = 358382, XrefRangeEnd = 358390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GCHandle FromIntPtr(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x001344C0 File Offset: 0x001326C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 358354, RefRangeEnd = 358365, XrefRangeStart = 358354, XrefRangeEnd = 358365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntPtr(GCHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GCHandle.NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00019C73 File Offset: 0x00017E73
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_GCHandleType_0;

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAllocated_Public_get_Boolean_0;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeMethodInfoPtr_AddrOfPinnedObject_Public_IntPtr_0;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_0;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_Static_GCHandle_Object_GCHandleType_0;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_GCHandle_0;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_GCHandle_IntPtr_0;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeMethodInfoPtr_CheckCurrentDomain_Private_Static_Boolean_Int32_0;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Private_Static_Object_Int32_0;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetHandle_Private_Static_Int32_Object_Int32_GCHandleType_0;

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeMethodInfoPtr_FreeHandle_Private_Static_Void_Int32_0;

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeMethodInfoPtr_GetAddrOfPinnedObject_Private_Static_IntPtr_Int32_0;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GCHandle_GCHandle_0;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeMethodInfoPtr_FromIntPtr_Public_Static_GCHandle_IntPtr_0;

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeMethodInfoPtr_ToIntPtr_Public_Static_IntPtr_GCHandle_0;

		// Token: 0x040036E8 RID: 14056
		[FieldOffset(0)]
		public int handle;
	}
}
