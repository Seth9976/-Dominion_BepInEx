using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000143 RID: 323
	public class PointerSpec : Object
	{
		// Token: 0x060016BA RID: 5818 RVA: 0x000882C0 File Offset: 0x000864C0
		// Note: this type is marked as 'beforefieldinit'.
		static PointerSpec()
		{
			Il2CppClassPointerStore<PointerSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "PointerSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr);
			PointerSpec.NativeFieldInfoPtr_pointer_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, "pointer_level");
			PointerSpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667112);
			PointerSpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667113);
			PointerSpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667114);
			PointerSpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667115);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00088354 File Offset: 0x00086554
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerSpec(int pointer_level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointer_level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0008839C File Offset: 0x0008659C
		[CallerCount(0)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000883EC File Offset: 0x000865EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309198, XrefRangeEnd = 309200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0008843C File Offset: 0x0008663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309200, XrefRangeEnd = 309206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerSpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00008063 File Offset: 0x00006263
		public PointerSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00088480 File Offset: 0x00086680
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0000806C File Offset: 0x0000626C
		public unsafe int pointer_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerSpec.NativeFieldInfoPtr_pointer_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerSpec.NativeFieldInfoPtr_pointer_level)) = value;
			}
		}

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeFieldInfoPtr_pointer_level;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
