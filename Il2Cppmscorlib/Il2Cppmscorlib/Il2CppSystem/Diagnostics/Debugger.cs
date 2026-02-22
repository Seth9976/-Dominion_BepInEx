using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BC RID: 1212
	public sealed class Debugger : Object
	{
		// Token: 0x0600474D RID: 18253 RVA: 0x00147C28 File Offset: 0x00145E28
		// Note: this type is marked as 'beforefieldinit'.
		static Debugger()
		{
			Il2CppClassPointerStore<Debugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "Debugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debugger>.NativeClassPtr);
			Debugger.NativeFieldInfoPtr_DefaultCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "DefaultCategory");
			Debugger.NativeMethodInfoPtr_get_IsAttached_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100673874);
			Debugger.NativeMethodInfoPtr_IsAttached_internal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100673875);
			Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100673876);
			Debugger.NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100673877);
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x00147CBC File Offset: 0x00145EBC
		public unsafe static bool IsAttached
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 365702, RefRangeEnd = 365703, XrefRangeStart = 365698, XrefRangeEnd = 365702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_get_IsAttached_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x00147CEC File Offset: 0x00145EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365703, XrefRangeEnd = 365704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAttached_internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_IsAttached_internal_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x00147D1C File Offset: 0x00145F1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283600, RefRangeEnd = 283603, XrefRangeStart = 283600, XrefRangeEnd = 283603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(int level, string category, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00147D74 File Offset: 0x00145F74
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyOfCrossThreadDependency()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x0001AEDB File Offset: 0x000190DB
		public Debugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x00147D9C File Offset: 0x00145F9C
		// (set) Token: 0x06004754 RID: 18260 RVA: 0x0001AEE4 File Offset: 0x000190E4
		public unsafe static string DefaultCategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debugger.NativeFieldInfoPtr_DefaultCategory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debugger.NativeFieldInfoPtr_DefaultCategory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039CD RID: 14797
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCategory;

		// Token: 0x040039CE RID: 14798
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttached_Public_Static_get_Boolean_0;

		// Token: 0x040039CF RID: 14799
		private static readonly IntPtr NativeMethodInfoPtr_IsAttached_internal_Private_Static_Boolean_0;

		// Token: 0x040039D0 RID: 14800
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0;

		// Token: 0x040039D1 RID: 14801
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0;
	}
}
