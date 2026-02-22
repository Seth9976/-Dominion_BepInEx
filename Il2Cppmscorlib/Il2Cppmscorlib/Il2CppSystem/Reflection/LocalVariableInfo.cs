using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C9 RID: 457
	public class LocalVariableInfo : Object
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x000A5F98 File Offset: 0x000A4198
		// Note: this type is marked as 'beforefieldinit'.
		static LocalVariableInfo()
		{
			Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "LocalVariableInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr);
			LocalVariableInfo.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "type");
			LocalVariableInfo.NativeFieldInfoPtr_is_pinned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "is_pinned");
			LocalVariableInfo.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "position");
			LocalVariableInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, 100668187);
			LocalVariableInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, 100668188);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x000A602C File Offset: 0x000A422C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariableInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariableInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000A6068 File Offset: 0x000A4268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318300, XrefRangeEnd = 318310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalVariableInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0000A1C9 File Offset: 0x000083C9
		public LocalVariableInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000A60AC File Offset: 0x000A42AC
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000A1D2 File Offset: 0x000083D2
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000A60DC File Offset: 0x000A42DC
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0000A1F1 File Offset: 0x000083F1
		public unsafe bool is_pinned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_is_pinned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_is_pinned)) = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000A6104 File Offset: 0x000A4304
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0000A20C File Offset: 0x0000840C
		public unsafe ushort position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr_is_pinned;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
