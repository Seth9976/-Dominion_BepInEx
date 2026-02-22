using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Common.Util
{
	// Token: 0x02000312 RID: 786
	public class IdFactory : Object
	{
		// Token: 0x06002D58 RID: 11608 RVA: 0x000C175C File Offset: 0x000BF95C
		// Note: this type is marked as 'beforefieldinit'.
		static IdFactory()
		{
			Il2CppClassPointerStore<IdFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Util", "IdFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdFactory>.NativeClassPtr);
			IdFactory.NativeFieldInfoPtr_PP_ID_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdFactory>.NativeClassPtr, "PP_ID_KEY");
			IdFactory.NativeMethodInfoPtr_get_NextId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdFactory>.NativeClassPtr, 100669219);
			IdFactory.NativeMethodInfoPtr_get_RandomString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdFactory>.NativeClassPtr, 100669220);
			IdFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdFactory>.NativeClassPtr, 100669221);
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000C17DC File Offset: 0x000BF9DC
		public unsafe static int NextId
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 212365, RefRangeEnd = 212382, XrefRangeStart = 212358, XrefRangeEnd = 212365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdFactory.NativeMethodInfoPtr_get_NextId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000C180C File Offset: 0x000BFA0C
		public unsafe static string RandomString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212382, XrefRangeEnd = 212411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdFactory.NativeMethodInfoPtr_get_RandomString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000C1838 File Offset: 0x000BFA38
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x0001196F File Offset: 0x0000FB6F
		public IdFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000C1874 File Offset: 0x000BFA74
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x00011978 File Offset: 0x0000FB78
		public unsafe static string PP_ID_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IdFactory.NativeFieldInfoPtr_PP_ID_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IdFactory.NativeFieldInfoPtr_PP_ID_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeFieldInfoPtr_PP_ID_KEY;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeMethodInfoPtr_get_NextId_Public_Static_get_Int32_0;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeMethodInfoPtr_get_RandomString_Public_Static_get_String_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CC RID: 972
		[ObfuscatedName("SA.Common.Util.IdFactory+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600386A RID: 14442 RVA: 0x000E5B8C File Offset: 0x000E3D8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<IdFactory.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdFactory>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdFactory.__c__DisplayClass4_0>.NativeClassPtr);
				IdFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdFactory.__c__DisplayClass4_0>.NativeClassPtr, "random");
				IdFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdFactory.__c__DisplayClass4_0>.NativeClassPtr, 100670437);
				IdFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__get_RandomString_b__0_Internal_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdFactory.__c__DisplayClass4_0>.NativeClassPtr, 100670438);
			}

			// Token: 0x0600386B RID: 14443 RVA: 0x000E5BF4 File Offset: 0x000E3DF4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdFactory.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600386C RID: 14444 RVA: 0x000E5C30 File Offset: 0x000E3E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212351, XrefRangeEnd = 212358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char _get_RandomString_b__0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__get_RandomString_b__0_Internal_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600386D RID: 14445 RVA: 0x00015D7A File Offset: 0x00013F7A
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D52 RID: 3410
			// (get) Token: 0x0600386E RID: 14446 RVA: 0x000E5C80 File Offset: 0x000E3E80
			// (set) Token: 0x0600386F RID: 14447 RVA: 0x00015D83 File Offset: 0x00013F83
			public unsafe Random random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032ED RID: 13037
			private static readonly IntPtr NativeFieldInfoPtr_random;

			// Token: 0x040032EE RID: 13038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040032EF RID: 13039
			private static readonly IntPtr NativeMethodInfoPtr__get_RandomString_b__0_Internal_Char_String_0;
		}
	}
}
