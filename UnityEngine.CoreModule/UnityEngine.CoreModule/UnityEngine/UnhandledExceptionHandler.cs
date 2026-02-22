using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C3 RID: 195
	public sealed class UnhandledExceptionHandler : Object
	{
		// Token: 0x06001120 RID: 4384 RVA: 0x0000A5D4 File Offset: 0x000087D4
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionHandler()
		{
			Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnhandledExceptionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr);
			UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, 100664473);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00045B7C File Offset: 0x00043D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72624, XrefRangeEnd = 72640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUECatcher()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000A60D File Offset: 0x0000880D
		public UnhandledExceptionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0;

		// Token: 0x020007AC RID: 1964
		[ObfuscatedName("UnityEngine.UnhandledExceptionHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002CF9 RID: 11513 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr);
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9");
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9__0_0");
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100664475);
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100664476);
			}

			// Token: 0x06002CFA RID: 11514 RVA: 0x0006C82C File Offset: 0x0006AA2C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CFB RID: 11515 RVA: 0x0006C868 File Offset: 0x0006AA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72615, XrefRangeEnd = 72624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterUECatcher_b__0_0(Object sender, UnhandledExceptionEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CFC RID: 11516 RVA: 0x00015425 File Offset: 0x00013625
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x06002CFD RID: 11517 RVA: 0x0006C8BC File Offset: 0x0006AABC
			// (set) Token: 0x06002CFE RID: 11518 RVA: 0x0001542E File Offset: 0x0001362E
			public unsafe static UnhandledExceptionHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x06002CFF RID: 11519 RVA: 0x0006C8E4 File Offset: 0x0006AAE4
			// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00015440 File Offset: 0x00013640
			public unsafe static UnhandledExceptionEventHandler __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CA5 RID: 7333
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001CA6 RID: 7334
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001CA7 RID: 7335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001CA8 RID: 7336
			private static readonly IntPtr NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0;
		}

		// Token: 0x020007AD RID: 1965
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
