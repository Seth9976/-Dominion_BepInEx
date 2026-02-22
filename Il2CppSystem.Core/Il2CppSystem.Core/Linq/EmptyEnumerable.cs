using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000008 RID: 8
	public class EmptyEnumerable<TElement> : Object
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00005044 File Offset: 0x00003244
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyEnumerable()
		{
			Il2CppClassPointerStore<EmptyEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "EmptyEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyEnumerable<TElement>>.NativeClassPtr);
			EmptyEnumerable<TElement>.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyEnumerable<TElement>>.NativeClassPtr, "Instance");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000021F9 File Offset: 0x000003F9
		public EmptyEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000050C4 File Offset: 0x000032C4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002202 File Offset: 0x00000402
		public unsafe static Il2CppArrayBase<TElement> Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyEnumerable<TElement>.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyEnumerable<TElement>.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_Instance;
	}
}
