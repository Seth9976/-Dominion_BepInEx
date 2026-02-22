using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Utility
{
	// Token: 0x02000015 RID: 21
	public class SA_IdFactory : Object
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000062D0 File Offset: 0x000044D0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_IdFactory()
		{
			Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_IdFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr);
			SA_IdFactory.NativeFieldInfoPtr_PP_ID_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr, "PP_ID_KEY");
			SA_IdFactory.NativeMethodInfoPtr_get_NextId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr, 100663407);
			SA_IdFactory.NativeMethodInfoPtr_get_RandomString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr, 100663408);
			SA_IdFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr, 100663409);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006350 File Offset: 0x00004550
		public unsafe static int NextId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99064, XrefRangeEnd = 99071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IdFactory.NativeMethodInfoPtr_get_NextId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006380 File Offset: 0x00004580
		public unsafe static string RandomString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99071, XrefRangeEnd = 99079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IdFactory.NativeMethodInfoPtr_get_RandomString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000063AC File Offset: 0x000045AC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_IdFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_IdFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IdFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000021DD File Offset: 0x000003DD
		public SA_IdFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000063E8 File Offset: 0x000045E8
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000021E6 File Offset: 0x000003E6
		public unsafe static string PP_ID_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_IdFactory.NativeFieldInfoPtr_PP_ID_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_IdFactory.NativeFieldInfoPtr_PP_ID_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_PP_ID_KEY;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_NextId_Public_Static_get_Int32_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_RandomString_Public_Static_get_String_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
