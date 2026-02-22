using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000113 RID: 275
	public static class EmptyArray<T> : Object
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x0007F35C File Offset: 0x0007D55C
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyArray()
		{
			Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EmptyArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr);
			EmptyArray<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr, "Value");
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000071FD File Offset: 0x000053FD
		public EmptyArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0007F3DC File Offset: 0x0007D5DC
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00007206 File Offset: 0x00005406
		public unsafe static Il2CppArrayBase<T> Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyArray<T>.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyArray<T>.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr_Value;
	}
}
