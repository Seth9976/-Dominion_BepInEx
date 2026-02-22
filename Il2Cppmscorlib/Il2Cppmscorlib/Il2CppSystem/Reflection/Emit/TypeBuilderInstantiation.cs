using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001F3 RID: 499
	public class TypeBuilderInstantiation : TypeInfo
	{
		// Token: 0x06001FEF RID: 8175 RVA: 0x0000AD0E File Offset: 0x00008F0E
		// Note: this type is marked as 'beforefieldinit'.
		static TypeBuilderInstantiation()
		{
			Il2CppClassPointerStore<TypeBuilderInstantiation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "TypeBuilderInstantiation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeBuilderInstantiation>.NativeClassPtr);
			TypeBuilderInstantiation.NativeMethodInfoPtr_MakeGenericType_Internal_Static_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilderInstantiation>.NativeClassPtr, 100668611);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000B216C File Offset: 0x000B036C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319750, RefRangeEnd = 319751, XrefRangeStart = 319744, XrefRangeEnd = 319750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakeGenericType(Type type, Il2CppReferenceArray<Type> typeArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBuilderInstantiation.NativeMethodInfoPtr_MakeGenericType_Internal_Static_Type_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0000AD47 File Offset: 0x00008F47
		public TypeBuilderInstantiation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Internal_Static_Type_Type_Il2CppReferenceArray_1_Type_0;
	}
}
