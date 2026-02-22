using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E7 RID: 999
	public class CADObjRef : Object
	{
		// Token: 0x06003F61 RID: 16225 RVA: 0x00126C80 File Offset: 0x00124E80
		// Note: this type is marked as 'beforefieldinit'.
		static CADObjRef()
		{
			Il2CppClassPointerStore<CADObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADObjRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr);
			CADObjRef.NativeFieldInfoPtr_objref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "objref");
			CADObjRef.NativeFieldInfoPtr_SourceDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "SourceDomain");
			CADObjRef.NativeFieldInfoPtr_TypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, "TypeInfo");
			CADObjRef.NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr, 100672568);
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00126D00 File Offset: 0x00124F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354313, XrefRangeEnd = 354315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADObjRef(ObjRef o, int sourceDomain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDomain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADObjRef.NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x00017FE8 File Offset: 0x000161E8
		public CADObjRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x00126D5C File Offset: 0x00124F5C
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x00017FF1 File Offset: 0x000161F1
		public unsafe ObjRef objref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_objref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_objref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x00126D8C File Offset: 0x00124F8C
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x00018010 File Offset: 0x00016210
		public unsafe int SourceDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_SourceDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_SourceDomain)) = value;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00126DB4 File Offset: 0x00124FB4
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x0001802B File Offset: 0x0001622B
		public unsafe Il2CppStructArray<byte> TypeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_TypeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADObjRef.NativeFieldInfoPtr_TypeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeFieldInfoPtr_objref;

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeFieldInfoPtr_SourceDomain;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeFieldInfoPtr_TypeInfo;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjRef_Int32_0;
	}
}
