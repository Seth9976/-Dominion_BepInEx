using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace UnityEngine
{
	// Token: 0x0200007E RID: 126
	public class UnityLogWriter : TextWriter
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x000349C4 File Offset: 0x00032BC4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityLogWriter()
		{
			Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnityLogWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr);
			UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663965);
			UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663966);
			UnityLogWriter.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663967);
			UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663968);
			UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663969);
			UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663970);
			UnityLogWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100663971);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00034A80 File Offset: 0x00032C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64802, XrefRangeEnd = 64804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringToUnityLog(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00034AB8 File Offset: 0x00032CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64804, XrefRangeEnd = 64806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringToUnityLogImpl(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00034AF0 File Offset: 0x00032CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64817, RefRangeEnd = 64818, XrefRangeStart = 64806, XrefRangeEnd = 64817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00034B18 File Offset: 0x00032D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64818, XrefRangeEnd = 64821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00034B64 File Offset: 0x00032D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64821, XrefRangeEnd = 64823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00034BB4 File Offset: 0x00032DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64823, XrefRangeEnd = 64826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00034C20 File Offset: 0x00032E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64826, XrefRangeEnd = 64830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityLogWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000090A9 File Offset: 0x000072A9
		public UnityLogWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00034C5C File Offset: 0x00032E5C
		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
