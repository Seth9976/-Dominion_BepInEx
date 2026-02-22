using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200008C RID: 140
	[Serializable]
	[StructLayout(2)]
	public struct ConsoleKeyInfo
	{
		// Token: 0x06000876 RID: 2166 RVA: 0x00047FA8 File Offset: 0x000461A8
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleKeyInfo()
		{
			Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleKeyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr);
			ConsoleKeyInfo.NativeFieldInfoPtr__keyChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_keyChar");
			ConsoleKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_key");
			ConsoleKeyInfo.NativeFieldInfoPtr__mods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_mods");
			ConsoleKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664644);
			ConsoleKeyInfo.NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664645);
			ConsoleKeyInfo.NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664646);
			ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664647);
			ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664648);
			ConsoleKeyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664649);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0004808C File Offset: 0x0004628C
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 278047, RefRangeEnd = 278110, XrefRangeStart = 278047, XrefRangeEnd = 278047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref control;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000480F8 File Offset: 0x000462F8
		public unsafe char KeyChar
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 210360, RefRangeEnd = 210362, XrefRangeStart = 210360, XrefRangeEnd = 210362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00048128 File Offset: 0x00046328
		public unsafe ConsoleKey Key
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00048158 File Offset: 0x00046358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278110, XrefRangeEnd = 278113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0004819C File Offset: 0x0004639C
		[CallerCount(0)]
		public unsafe bool Equals(ConsoleKeyInfo obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000481DC File Offset: 0x000463DC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000048B1 File Offset: 0x00002AB1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr__keyChar;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr__mods;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040006E4 RID: 1764
		[FieldOffset(0)]
		public char _keyChar;

		// Token: 0x040006E5 RID: 1765
		[FieldOffset(4)]
		public ConsoleKey _key;

		// Token: 0x040006E6 RID: 1766
		[FieldOffset(8)]
		public ConsoleModifiers _mods;
	}
}
