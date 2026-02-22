using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000099 RID: 153
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x06000F73 RID: 3955 RVA: 0x00040348 File Offset: 0x0003E548
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceRequest()
		{
			Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourceRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr);
			ResourceRequest.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, "m_Path");
			ResourceRequest.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, "m_Type");
			ResourceRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100664280);
			ResourceRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100664281);
			ResourceRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr, 100664282);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000403DC File Offset: 0x0003E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68018, XrefRangeEnd = 68019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00040428 File Offset: 0x0003E628
		public unsafe Object asset
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 68019, RefRangeEnd = 68021, XrefRangeStart = 68019, XrefRangeEnd = 68019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00040468 File Offset: 0x0003E668
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00009BA9 File Offset: 0x00007DA9
		public ResourceRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x000404A4 File Offset: 0x0003E6A4
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00009BB2 File Offset: 0x00007DB2
		public unsafe string m_Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x000404CC File Offset: 0x0003E6CC
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00009BD1 File Offset: 0x00007DD1
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceRequest.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Protected_Virtual_New_Object_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_Object_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
