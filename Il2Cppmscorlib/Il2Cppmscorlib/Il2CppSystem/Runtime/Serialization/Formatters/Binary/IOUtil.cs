using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000353 RID: 851
	public static class IOUtil : Object
	{
		// Token: 0x06003663 RID: 13923 RVA: 0x001083C4 File Offset: 0x001065C4
		// Note: this type is marked as 'beforefieldinit'.
		static IOUtil()
		{
			Il2CppClassPointerStore<IOUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IOUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOUtil>.NativeClassPtr);
			IOUtil.NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671670);
			IOUtil.NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671671);
			IOUtil.NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671672);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00108430 File Offset: 0x00106630
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 344903, RefRangeEnd = 344908, XrefRangeStart = 344903, XrefRangeEnd = 344903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FlagTest(MessageEnum flag, MessageEnum target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0010847C File Offset: 0x0010667C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 344912, RefRangeEnd = 344916, XrefRangeStart = 344908, XrefRangeEnd = 344912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringWithCode(string value, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x001084C4 File Offset: 0x001066C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344931, RefRangeEnd = 344934, XrefRangeStart = 344916, XrefRangeEnd = 344931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWithCode(Type type, Object value, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x000138E0 File Offset: 0x00011AE0
		public IOUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0;
	}
}
