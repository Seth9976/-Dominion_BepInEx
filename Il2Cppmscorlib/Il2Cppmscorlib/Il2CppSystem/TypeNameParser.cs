using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000109 RID: 265
	public sealed class TypeNameParser : Object
	{
		// Token: 0x060013A4 RID: 5028 RVA: 0x00006C00 File Offset: 0x00004E00
		// Note: this type is marked as 'beforefieldinit'.
		static TypeNameParser()
		{
			Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeNameParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr);
			TypeNameParser.NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeNameParser>.NativeClassPtr, 100666701);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0007CB80 File Offset: 0x0007AD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304550, XrefRangeEnd = 304566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeResolver);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeNameParser.NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00006C39 File Offset: 0x00004E39
		public TypeNameParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0;
	}
}
